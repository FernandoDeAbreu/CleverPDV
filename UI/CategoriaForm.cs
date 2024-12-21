using Clever.Application.Interfaces;
using Clever.Domain.Core.Interfaces.Repositorys;
using Clever.Shared.Dtos;

namespace UI;

public partial class CategoriaForm : Form
{
    private readonly ICategoriaAppService _appService;

    public CategoriaForm(ICategoriaAppService appService)
    {
        _appService = appService;
        InitializeComponent();
    }

    private async void CategoriaForm_Load(object sender, EventArgs e)
    {
        await LimparCampos();
    }

    private async void BtnSalvar_ClickAsync(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tboxDescricao.Text))
        {
            var categoriaDto = new CategoriaDto
            {
                Descricao = tboxDescricao.Text,
            };

            if (string.IsNullOrEmpty(tboxCodigo.Text))
                await _appService.Create(categoriaDto);
            else
            {
                var categoriaExist = await _appService.GetAsNoTracking(int.Parse(tboxCodigo.Text));
                categoriaExist.Descricao = tboxDescricao.Text;

                await _appService.UpdateAsync(categoriaExist);
            }

            await LimparCampos();
        }
    }

    private void DgvResponse_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        tboxCodigo.Text = dgvResponse.CurrentRow.Cells["Id"].Value.ToString();
        tboxDescricao.Text = dgvResponse.CurrentRow.Cells["Descricao"].Value.ToString();
    }

    private async Task LimparCampos()
    {
        tboxCodigo.Clear();
        tboxDescricao.Clear();
        tboxDescricao.Focus();
        await AjustarNomesColunasAsync();
    }

    private async Task AjustarNomesColunasAsync()
    {
        var response = await _appService.GetAll();
        dgvResponse.DataSource = response;
        dgvResponse.Columns["Id"].HeaderText = "Código";
        dgvResponse.Columns["Descricao"].HeaderText = "Descrição";
        dgvResponse.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private async void DgvResponse_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            if (MessageBox.Show("Deseja excluir o item?", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                await _appService.Delete(int.Parse(dgvResponse.CurrentRow.Cells["Id"].Value.ToString() ?? "0"));
                await LimparCampos();
            }
        }
    }
}