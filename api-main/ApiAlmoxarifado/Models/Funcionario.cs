using System.ComponentModel.DataAnnotations;

namespace ApiAlmoxarifado.Models
{
    public class Funcionario
    {
        [Key]
        public int funcID { get; set; }
        public string nome { get; set; }
        public string cargo { get; set; }
        public DateTime dataNascimento { get; set; }
        public decimal salario { get; set; }
        public string endereço { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }

    }
}
