using System.ComponentModel.DataAnnotations;

namespace ApiAlmoxarifado.Models
{
    public class Departamento
    {
        [Key]
        public int depid { get; set; }
        public string descricao { get; set; }
        public bool ativado { get; set; } = false;
    }
}
