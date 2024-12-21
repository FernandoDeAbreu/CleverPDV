using Clever.Application.Interfaces;
using Clever.Domain.Core.Interfaces.Repositorys;
using UI.Produto;

namespace UI;

public partial class MenuForm : Form
{
    private readonly IProdutoAppService _produtoAppService;
    private readonly ICategoriaAppService _categoriaAppService;

    public MenuForm(IProdutoAppService produtoAppService, ICategoriaAppService categoriaAppService)
    {
        _produtoAppService = produtoAppService;
        _categoriaAppService = categoriaAppService;

        InitializeComponent();
    }

    private void BtnProduto_Click(object sender, EventArgs e)
    {
        var frmProduto = new PesquisarFrm(_produtoAppService);
        frmProduto.ShowDialog();
    }

    private void BtnCategoria_Click(object sender, EventArgs e)
    {
        var frmCategoria = new CategoriaForm(_categoriaAppService);
        frmCategoria.ShowDialog();
    }
}