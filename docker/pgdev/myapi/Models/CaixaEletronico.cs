using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace myapi.Models
{
    public class CaixaEletronico
    {
        [Key]
        public int CaixaEletronicoId { get; set; }
        [Required]
        public List<Cliente> Clientes { get; set; }
    }
}
