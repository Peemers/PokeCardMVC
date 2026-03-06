using System.Text.Json.Serialization;

namespace PokeCardMvc.Models;

public class PokemonRessource
{
  public string Name { get; set; } = string.Empty;
  public string Image { get; set; } = string.Empty;
  public string Url { get; set; } = string.Empty;
}

public class ApiResponse
{
  public List<PokemonRessource> Results { get; set; } = new();
}

public class PokeSprites
{
  [JsonPropertyName("front_default")] public string FrontDefault { get; set; } = string.Empty;
}

public class PokeTypeInfo
{
  public string Name { get; set; } = string.Empty;
}

public class PokeTypeSlot
{
  [JsonPropertyName("type")] public PokeTypeInfo Type { get; set; } = new();
}

public class PokeDetailResponse
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public int Height { get; set; }
  public int Weight { get; set; }
  public PokeSprites Sprites { get; set; } = new();
  public List<PokeTypeSlot> Types { get; set; } = new();
}