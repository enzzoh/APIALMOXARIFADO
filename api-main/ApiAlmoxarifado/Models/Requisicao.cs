using System.ComponentModel.DataAnnotations;

namespace ApiAlmoxarifado.Models
{
    public class Requisicao
    {
        [Key]
        public int reqID { get; set; }
        public DateTime reqData { get; set; }
        public int reqObservacao { get; set; }
    }
}
