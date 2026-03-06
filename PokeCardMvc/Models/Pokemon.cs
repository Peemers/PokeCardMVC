using System.ComponentModel.DataAnnotations;

namespace PokeCardMvc.Models;

public class Pokemon
{
  public int Id { get; set; }
  [Required(ErrorMessage = "Le nom est obligatoire")]
  public string Name { get; set; } = string.Empty;
  [Required(ErrorMessage = "Le type est obligatoire")]
  public string Type { get; set; } = string.Empty;
  
  public string Image { get; set; } = string.Empty;

  public int Height { get; set; }
  public int Weight { get; set; }
}