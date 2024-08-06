namespace UI
{
    partial class ProdutoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tboxCodigo = new TextBox();
            tboxDescricao = new TextBox();
            tboxCodigoBarra = new TextBox();
            tboxCodigoFabrica = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tboxUnidadeMedida = new TextBox();
            label7 = new Label();
            tboxEstoqueAtual = new TextBox();
            label8 = new Label();
            tboxEstoqueMin = new TextBox();
            label9 = new Label();
            tboxPrecoCusto = new TextBox();
            label10 = new Label();
            tboxPrecoVenda = new TextBox();
            pictureBoxImagem = new PictureBox();
            btnEditarImagem = new Button();
            btnExcluirImagem = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label11 = new Label();
            tboxLucro = new TextBox();
            btnSalvar = new Button();
            btnPesquisar = new Button();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tboxCodigo
            // 
            tboxCodigo.BackColor = SystemColors.ButtonHighlight;
            tboxCodigo.Location = new Point(14, 30);
            tboxCodigo.Name = "tboxCodigo";
            tboxCodigo.ReadOnly = true;
            tboxCodigo.Size = new Size(125, 29);
            tboxCodigo.TabIndex = 1;
            // 
            // tboxDescricao
            // 
            tboxDescricao.Location = new Point(14, 82);
            tboxDescricao.MaxLength = 50;
            tboxDescricao.Name = "tboxDescricao";
            tboxDescricao.Size = new Size(942, 29);
            tboxDescricao.TabIndex = 2;
            // 
            // tboxCodigoBarra
            // 
            tboxCodigoBarra.Location = new Point(14, 137);
            tboxCodigoBarra.MaxLength = 50;
            tboxCodigoBarra.Name = "tboxCodigoBarra";
            tboxCodigoBarra.Size = new Size(349, 29);
            tboxCodigoBarra.TabIndex = 3;
            // 
            // tboxCodigoFabrica
            // 
            tboxCodigoFabrica.AcceptsReturn = true;
            tboxCodigoFabrica.Location = new Point(369, 137);
            tboxCodigoFabrica.MaxLength = 50;
            tboxCodigoFabrica.Name = "tboxCodigoFabrica";
            tboxCodigoFabrica.Size = new Size(349, 29);
            tboxCodigoFabrica.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(969, 35);
            label1.TabIndex = 5;
            label1.Text = "Cadastro de Produto";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 6;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 60);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 7;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 113);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 8;
            label4.Text = "Código de barras";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 113);
            label5.Name = "label5";
            label5.Size = new Size(132, 21);
            label5.TabIndex = 9;
            label5.Text = "Código de fabrica";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(722, 113);
            label6.Name = "label6";
            label6.Size = new Size(145, 21);
            label6.TabIndex = 11;
            label6.Text = "Unidade de medida";
            // 
            // tboxUnidadeMedida
            // 
            tboxUnidadeMedida.Location = new Point(724, 137);
            tboxUnidadeMedida.MaxLength = 50;
            tboxUnidadeMedida.Name = "tboxUnidadeMedida";
            tboxUnidadeMedida.Size = new Size(229, 29);
            tboxUnidadeMedida.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 169);
            label7.Name = "label7";
            label7.Size = new Size(103, 21);
            label7.TabIndex = 13;
            label7.Text = "Estoque atual";
            // 
            // tboxEstoqueAtual
            // 
            tboxEstoqueAtual.Location = new Point(14, 193);
            tboxEstoqueAtual.MaxLength = 50;
            tboxEstoqueAtual.Name = "tboxEstoqueAtual";
            tboxEstoqueAtual.Size = new Size(231, 29);
            tboxEstoqueAtual.TabIndex = 12;
            tboxEstoqueAtual.Text = "0,00";
            tboxEstoqueAtual.TextAlign = HorizontalAlignment.Right;
            tboxEstoqueAtual.Leave += tboxEstoqueAtual_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 169);
            label8.Name = "label8";
            label8.Size = new Size(99, 21);
            label8.TabIndex = 15;
            label8.Text = "Estoque min.";
            // 
            // tboxEstoqueMin
            // 
            tboxEstoqueMin.Location = new Point(251, 193);
            tboxEstoqueMin.MaxLength = 50;
            tboxEstoqueMin.Name = "tboxEstoqueMin";
            tboxEstoqueMin.Size = new Size(231, 29);
            tboxEstoqueMin.TabIndex = 14;
            tboxEstoqueMin.Text = "0,00";
            tboxEstoqueMin.TextAlign = HorizontalAlignment.Right;
            tboxEstoqueMin.Leave += tboxEstoqueMin_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(485, 169);
            label9.Name = "label9";
            label9.Size = new Size(111, 21);
            label9.TabIndex = 17;
            label9.Text = "Preço de custo";
            // 
            // tboxPrecoCusto
            // 
            tboxPrecoCusto.Location = new Point(485, 193);
            tboxPrecoCusto.MaxLength = 50;
            tboxPrecoCusto.Name = "tboxPrecoCusto";
            tboxPrecoCusto.Size = new Size(231, 29);
            tboxPrecoCusto.TabIndex = 16;
            tboxPrecoCusto.Text = "0,00";
            tboxPrecoCusto.TextAlign = HorizontalAlignment.Right;
            tboxPrecoCusto.Leave += tboxPrecoCusto_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(725, 172);
            label10.Name = "label10";
            label10.Size = new Size(116, 21);
            label10.TabIndex = 19;
            label10.Text = "Preço de venda";
            // 
            // tboxPrecoVenda
            // 
            tboxPrecoVenda.Location = new Point(722, 193);
            tboxPrecoVenda.MaxLength = 50;
            tboxPrecoVenda.Name = "tboxPrecoVenda";
            tboxPrecoVenda.Size = new Size(231, 29);
            tboxPrecoVenda.TabIndex = 18;
            tboxPrecoVenda.Text = "0,00";
            tboxPrecoVenda.TextAlign = HorizontalAlignment.Right;
            tboxPrecoVenda.Leave += tboxPrecoVenda_Leave;
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImagem.Location = new Point(14, 239);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(223, 269);
            pictureBoxImagem.TabIndex = 20;
            pictureBoxImagem.TabStop = false;
            // 
            // btnEditarImagem
            // 
            btnEditarImagem.Location = new Point(244, 239);
            btnEditarImagem.Margin = new Padding(4);
            btnEditarImagem.Name = "btnEditarImagem";
            btnEditarImagem.Size = new Size(40, 36);
            btnEditarImagem.TabIndex = 21;
            btnEditarImagem.UseVisualStyleBackColor = true;
            // 
            // btnExcluirImagem
            // 
            btnExcluirImagem.Location = new Point(244, 276);
            btnExcluirImagem.Margin = new Padding(4);
            btnExcluirImagem.Name = "btnExcluirImagem";
            btnExcluirImagem.Size = new Size(40, 36);
            btnExcluirImagem.TabIndex = 22;
            btnExcluirImagem.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-3, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(970, 615);
            tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(tboxLucro);
            tabPage1.Controls.Add(btnSalvar);
            tabPage1.Controls.Add(btnPesquisar);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(btnExcluirImagem);
            tabPage1.Controls.Add(tboxPrecoVenda);
            tabPage1.Controls.Add(tboxCodigo);
            tabPage1.Controls.Add(tboxPrecoCusto);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(btnEditarImagem);
            tabPage1.Controls.Add(tboxUnidadeMedida);
            tabPage1.Controls.Add(tboxDescricao);
            tabPage1.Controls.Add(pictureBoxImagem);
            tabPage1.Controls.Add(tboxCodigoBarra);
            tabPage1.Controls.Add(tboxCodigoFabrica);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(tboxEstoqueMin);
            tabPage1.Controls.Add(tboxEstoqueAtual);
            tabPage1.Controls.Add(label7);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(962, 581);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(305, 225);
            label11.Name = "label11";
            label11.Size = new Size(49, 21);
            label11.TabIndex = 26;
            label11.Text = "Lucro";
            // 
            // tboxLucro
            // 
            tboxLucro.Location = new Point(305, 246);
            tboxLucro.Name = "tboxLucro";
            tboxLucro.Size = new Size(145, 29);
            tboxLucro.TabIndex = 25;
            tboxLucro.Text = "0,00";
            tboxLucro.Leave += tboxLucro_Leave;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(787, 530);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(166, 44);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(617, 530);
            btnPesquisar.Margin = new Padding(4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(166, 44);
            btnPesquisar.TabIndex = 24;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += BtnPesquisar_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(btnEditar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(962, 587);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(3, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(957, 444);
            dataGridView1.TabIndex = 5;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(785, 530);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(166, 44);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // ProdutoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 611);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProdutoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ProdutoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tboxCodigo;
        private TextBox tboxDescricao;
        private TextBox tboxCodigoBarra;
        private TextBox tboxCodigoFabrica;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tboxUnidadeMedida;
        private Label label7;
        private TextBox tboxEstoqueAtual;
        private Label label8;
        private TextBox tboxEstoqueMin;
        private Label label9;
        private TextBox tboxPrecoCusto;
        private Label label10;
        private TextBox tboxPrecoVenda;
        private PictureBox pictureBoxImagem;
        private Button btnEditarImagem;
        private Button btnExcluirImagem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnPesquisar;
        private DataGridView dataGridView1;
        private Label label11;
        private TextBox tboxLucro;
    }
}