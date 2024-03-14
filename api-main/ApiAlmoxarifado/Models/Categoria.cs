using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ApiAlmoxarifado.Models
{
    public class Categoria
    {
        [Key]
        public int categoriaid { get; set; }
        public string descricao { get; set; }

    }
}
