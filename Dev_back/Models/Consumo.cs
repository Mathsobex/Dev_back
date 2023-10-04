using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev_back.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigátorio informar a descrição")]
        [Display(Name ="Descrição")]
        public string Descrição { get; set; }

        [Required(ErrorMessage = "Obrigátorio informar a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigátorio informar o valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigátorio informar a quilometragem")]
        public int Km { get; set; }


        [Display(Name = "Tipo de combustível")]
        public TipoCombustivel Tipo { get; set; }


        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigátorio informar o veiculo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina, Etanol
    }

}
