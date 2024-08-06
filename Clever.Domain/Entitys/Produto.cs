using System.ComponentModel.DataAnnotations;

namespace Clever.Domain.Entitys;

public class Produto
{
    public int Id { get; set; }
    public string? Descricao { get; set; }

    [Display(Name = "Código de Barras")]
    public string? CodigoBarras { get; set; }

    public string CodigoFabrica { get; set; }
    public double Estoque { get; set; }
    public double EstoqueMin { get; set; }
    public double PrecoCusto { get; set; }
    public double PrecoVenda { get; set; }
    public string? Imagem { get; set; }
    public string? Medida { get; set; }
    public double? Lucro { get; set;}
}