using System.ComponentModel.DataAnnotations;

namespace ApiAlmoxarifado.Models
{
    public class MotivoSaida
    {
        [Key]
        public int motID { get; set; }
        public string motDescricao { get; set; }
        public int categoriaid { get; set; }
    }
}
