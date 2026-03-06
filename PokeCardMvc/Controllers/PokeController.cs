using Microsoft.AspNetCore.Mvc;
using PokeCardMvc.Models;

namespace PokeCardMvc.Controllers;

public class PokeController : Controller
{
  private static List<Pokemon> _AllPokemons = new List<Pokemon>();
  
  private readonly string _apiUrl =  "https://pokeapi.co/api/v2/pokemon?limit=20";

  [HttpGet] // <- lisibilité pas obligé
  public async Task<IActionResult> Index()
  {
    if (_AllPokemons.Count == 0)
    {
      using HttpClient client = new HttpClient();
      
      var response = await client.GetFromJsonAsync<ApiResponse>(_apiUrl);

      if (response != null)
      {
        foreach (var item in response.Results )
        {
          var detail = await client.GetFromJsonAsync<PokeDetailResponse>(item.Url);
          if (detail != null)
          {
            _AllPokemons.Add(new Pokemon
            {
              Id = detail.Id,
              Name = char.ToUpper(detail.Name[0]) + detail.Name.Substring(1),
              Height = detail.Height,
              Weight = detail.Weight,
              Image = detail.Sprites.FrontDefault
            });
          }
        }
      }
    }
    return View(_AllPokemons);
  }

  public IActionResult details(int id)
  {
    var pokemon = _AllPokemons.FirstOrDefault(p => p.Id == id);

    if (pokemon == null)
    {
      return NotFound();
    }
    return View(pokemon);
  }
  
}