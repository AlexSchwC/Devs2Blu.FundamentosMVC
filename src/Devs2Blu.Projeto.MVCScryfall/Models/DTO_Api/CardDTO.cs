using System.Reflection.PortableExecutable;

namespace Devs2Blu.Projeto.MVCScryfall.Models.DTO_Api
{
    public class MagicCardModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image_uris { get; set; }
        public string? Mana_cost { get; set; }
        public string? Type_line { get; set; }
        public List<string>? Keywords { get; set; }
        public string? Set_name { get; set; }
        public string? Flavor_text { get; set; }
        public string? Artist { get; set; }
    }
}
