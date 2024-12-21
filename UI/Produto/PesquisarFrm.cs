using Clever.Application.Interfaces;

namespace UI.Produto
{
    public partial class PesquisarFrm : Form
    {
        private readonly IProdutoAppService _produtoAppService;

        public PesquisarFrm(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;

            InitializeComponent();
        }

        private async void PesquisarFrm_Load(object sender, EventArgs e)
        {
            await LimparCampos();
        }

        private async Task LimparCampos()
        {
            await AjustarNomesColunasAsync();
        }

        private async Task AjustarNomesColunasAsync()
        {
            var response = await _produtoAppService.GetAll();
            dgvResponse.DataSource = response;
            dgvResponse.Columns["Id"].HeaderText = "Código";
            dgvResponse.Columns["Descricao"].HeaderText = "Descrição";
        }

        private async void BtnNovo_Click(object sender, EventArgs e)
        {
            var Novo = new ProdutoForm(0, _produtoAppService);
            Novo.ShowDialog();
            await LimparCampos();
        }

        private async void DgvResponse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvResponse.CurrentRow.Cells["Id"].Value.ToString() ?? "0");
            var Novo = new ProdutoForm(id, _produtoAppService);
            Novo.ShowDialog();
            await LimparCampos();
        }
    }
}