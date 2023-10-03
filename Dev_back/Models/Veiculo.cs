using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev_back.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigátorio informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigátorio informar a placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigátorio informar o ano de fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigátorio informar o ano do modelo")]
        public int AnoModelo { get; set; }
    }

}
