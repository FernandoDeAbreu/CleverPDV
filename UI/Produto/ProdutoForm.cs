using Clever.Application.Interfaces;
using Clever.Shared.Dtos;

namespace UI;

public partial class ProdutoForm : Form
{
    private readonly IProdutoAppService _produtoAppService;
    private readonly int _produtoId;

    public ProdutoForm(int produtoId, IProdutoAppService produtoAppService)
    {
        _produtoId = produtoId;
        _produtoAppService = produtoAppService;
        InitializeComponent();
    }

    private async void ProdutoForm_Load(object sender, EventArgs e)
    {
        if (_produtoId != 0)
            await CarregarItem();
    }

    private async Task CarregarItem()
    {
        var _produto = await _produtoAppService.GetById(_produtoId);

        if (_produto != null)
        {
            tboxDescricao.Text = _produto.Descricao;
            tboxPrecoCusto.Text = _produto.PrecoCusto.ToString();
        }
    }

    private async void BtnSalvar_Click(object sender, EventArgs e)
    {
        var produto = new ProdutoDto
        {
            Descricao = tboxDescricao.Text,
            CodigoFabrica = tboxCodigoBarra.Text,
            Estoque = double.Parse(tboxEstoqueAtual.Text)
        };

        await _produtoAppService.Create(produto);
    }

    private void TboxEstoqueAtual_Leave(object sender, EventArgs e)
    {
        try
        {
            tboxEstoqueAtual.Text = double.Parse(tboxEstoqueAtual.Text).ToString("N2");
        }
        catch (Exception)
        {
            tboxEstoqueAtual.Text = double.Parse("0,00").ToString("N2");
        }
    }

    private void TboxEstoqueMin_Leave(object sender, EventArgs e)
    {
        try
        {
            tboxEstoqueMin.Text = double.Parse(tboxEstoqueMin.Text).ToString("N2");
        }
        catch (Exception)
        {
            tboxEstoqueMin.Text = double.Parse("0,00").ToString("N2");
        }
    }

    private void TboxPrecoCusto_Leave(object sender, EventArgs e)
    {
        try
        {
            tboxPrecoCusto.Text = double.Parse(tboxPrecoCusto.Text).ToString("N2");
        }
        catch (Exception)
        {
            tboxPrecoCusto.Text = double.Parse("0,00").ToString("N2");
        }
    }

    private void TboxPrecoVenda_Leave(object sender, EventArgs e)
    {
        try
        {
            tboxPrecoVenda.Text = double.Parse(tboxPrecoVenda.Text).ToString("N2");
        }
        catch (Exception)
        {
            tboxPrecoVenda.Text = double.Parse("0,00").ToString("N2");
        }
    }
}