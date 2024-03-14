using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAlmoxarifado.Models
{
    public class Produto
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }

        public int estoque { get; set; }

        public string? photourl { get; set;}

        public int? fk_cod_categoria { get; set; }
    }
}
