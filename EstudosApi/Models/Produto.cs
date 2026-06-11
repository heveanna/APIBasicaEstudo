namespace EstudosApi.Models;
public class Produto
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public decimal Preco { get; set; }
    public int quatidadeEstoque {get; set; }
}
