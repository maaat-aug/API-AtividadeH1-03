using System.ComponentModel.DataAnnotations;

namespace ProdutoCodigo.Models
{
    public class Produto
    {
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string? descricao { get; set; }
        [Required]
        [MaxLength(10)]
        public double? preco { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string? estoque { get; set; }

        [Required]
        [MaxLength(8)]
        [MinLength(8)]
        public string codigoProduto { get; set; }
    }
}
