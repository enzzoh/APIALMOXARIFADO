using System.ComponentModel.DataAnnotations;

namespace ApiAlmoxarifado.Models
{
    public class CategoriaMotivo
    {
        [Key]
        public int camID { get; set; }
        public string camDescricao { get; set; }
    }
}
