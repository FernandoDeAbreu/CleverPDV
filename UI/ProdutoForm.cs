using Clever.Application.Interfaces;
using Clever.Shared.Dtos;

namespace UI
{
    public partial class ProdutoForm : Form
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutoForm(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;

            InitializeComponent();
        }

        private async void BtnSalvar_Click(object sender, EventArgs e)
        {
            var produto = new ProdutoDto
            {
                Descricao = tboxDescricao.Text,
                CodigoBarras = tboxCodigoBarra.Text,
                Estoque = double.Parse(tboxEstoqueAtual.Text),
                CodigoFabrica = tboxCodigoFabrica.Text,
                EstoqueMin = double.Parse(tboxEstoqueMin.Text),
                Medida = tboxUnidadeMedida.Text,
                PrecoCusto = double.Parse(tboxPrecoCusto.Text),
                PrecoVenda = double.Parse(tboxPrecoVenda.Text),
                Lucro = double.Parse(tboxLucro.Text),

            };

            await _produtoAppService.Create(produto);


        }

        private void tboxEstoqueAtual_Leave(object sender, EventArgs e)
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

        private void tboxEstoqueMin_Leave(object sender, EventArgs e)
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

        private void tboxPrecoCusto_Leave(object sender, EventArgs e)
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

        private void tboxPrecoVenda_Leave(object sender, EventArgs e)
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

        private async void BtnPesquisar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            var t = await _produtoAppService.GetAll();
            dataGridView1.DataSource = t;
        }

        private void ProdutoForm_Load(object sender, EventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void tboxLucro_Leave(object sender, EventArgs e)
        {
            try
            {
                tboxLucro.Text = double.Parse(tboxLucro.Text).ToString("N2");
            }
            catch (Exception)
            {
                tboxLucro.Text = "0,00";
                
            }
        }
    }
}