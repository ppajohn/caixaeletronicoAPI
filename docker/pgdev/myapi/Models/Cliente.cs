using System.ComponentModel.DataAnnotations;

namespace myapi.Models

{

    public class Cliente
    {

        [Key]
        public int ClienteId { get; set; }
        [Required]
        public int CaixaEletronicoId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Saldo { get; set; }
    }
}