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
            btnSalvar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            SuspendLayout();
            // 
            // tboxCodigo
            // 
            tboxCodigo.BackColor = SystemColors.ButtonHighlight;
            tboxCodigo.Location = new Point(18, 55);
            tboxCodigo.Name = "tboxCodigo";
            tboxCodigo.ReadOnly = true;
            tboxCodigo.Size = new Size(125, 29);
            tboxCodigo.TabIndex = 1;
            // 
            // tboxDescricao
            // 
            tboxDescricao.Location = new Point(18, 107);
            tboxDescricao.MaxLength = 50;
            tboxDescricao.Name = "tboxDescricao";
            tboxDescricao.Size = new Size(942, 29);
            tboxDescricao.TabIndex = 2;
            // 
            // tboxCodigoBarra
            // 
            tboxCodigoBarra.Location = new Point(18, 162);
            tboxCodigoBarra.MaxLength = 50;
            tboxCodigoBarra.Name = "tboxCodigoBarra";
            tboxCodigoBarra.Size = new Size(349, 29);
            tboxCodigoBarra.TabIndex = 3;
            // 
            // tboxCodigoFabrica
            // 
            tboxCodigoFabrica.AcceptsReturn = true;
            tboxCodigoFabrica.Location = new Point(373, 162);
            tboxCodigoFabrica.MaxLength = 50;
            tboxCodigoFabrica.Name = "tboxCodigoFabrica";
            tboxCodigoFabrica.Size = new Size(349, 29);
            tboxCodigoFabrica.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 35);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 6;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 85);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 7;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 138);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 8;
            label4.Text = "Código de barras";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 138);
            label5.Name = "label5";
            label5.Size = new Size(132, 21);
            label5.TabIndex = 9;
            label5.Text = "Código de fabrica";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(726, 138);
            label6.Name = "label6";
            label6.Size = new Size(145, 21);
            label6.TabIndex = 11;
            label6.Text = "Unidade de medida";
            // 
            // tboxUnidadeMedida
            // 
            tboxUnidadeMedida.Location = new Point(728, 162);
            tboxUnidadeMedida.MaxLength = 50;
            tboxUnidadeMedida.Name = "tboxUnidadeMedida";
            tboxUnidadeMedida.Size = new Size(229, 29);
            tboxUnidadeMedida.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 194);
            label7.Name = "label7";
            label7.Size = new Size(103, 21);
            label7.TabIndex = 13;
            label7.Text = "Estoque atual";
            // 
            // tboxEstoqueAtual
            // 
            tboxEstoqueAtual.Location = new Point(18, 218);
            tboxEstoqueAtual.MaxLength = 50;
            tboxEstoqueAtual.Name = "tboxEstoqueAtual";
            tboxEstoqueAtual.Size = new Size(231, 29);
            tboxEstoqueAtual.TabIndex = 12;
            tboxEstoqueAtual.Text = "0,00";
            tboxEstoqueAtual.TextAlign = HorizontalAlignment.Right;
            tboxEstoqueAtual.Leave += TboxEstoqueAtual_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(252, 194);
            label8.Name = "label8";
            label8.Size = new Size(99, 21);
            label8.TabIndex = 15;
            label8.Text = "Estoque min.";
            // 
            // tboxEstoqueMin
            // 
            tboxEstoqueMin.Location = new Point(255, 218);
            tboxEstoqueMin.MaxLength = 50;
            tboxEstoqueMin.Name = "tboxEstoqueMin";
            tboxEstoqueMin.Size = new Size(231, 29);
            tboxEstoqueMin.TabIndex = 14;
            tboxEstoqueMin.Text = "0,00";
            tboxEstoqueMin.TextAlign = HorizontalAlignment.Right;
            tboxEstoqueMin.Leave += TboxEstoqueMin_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(489, 194);
            label9.Name = "label9";
            label9.Size = new Size(111, 21);
            label9.TabIndex = 17;
            label9.Text = "Preço de custo";
            // 
            // tboxPrecoCusto
            // 
            tboxPrecoCusto.Location = new Point(489, 218);
            tboxPrecoCusto.MaxLength = 50;
            tboxPrecoCusto.Name = "tboxPrecoCusto";
            tboxPrecoCusto.Size = new Size(231, 29);
            tboxPrecoCusto.TabIndex = 16;
            tboxPrecoCusto.Text = "0,00";
            tboxPrecoCusto.TextAlign = HorizontalAlignment.Right;
            tboxPrecoCusto.Leave += TboxPrecoCusto_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(723, 194);
            label10.Name = "label10";
            label10.Size = new Size(116, 21);
            label10.TabIndex = 19;
            label10.Text = "Preço de venda";
            // 
            // tboxPrecoVenda
            // 
            tboxPrecoVenda.Location = new Point(726, 218);
            tboxPrecoVenda.MaxLength = 50;
            tboxPrecoVenda.Name = "tboxPrecoVenda";
            tboxPrecoVenda.Size = new Size(231, 29);
            tboxPrecoVenda.TabIndex = 18;
            tboxPrecoVenda.Text = "0,00";
            tboxPrecoVenda.TextAlign = HorizontalAlignment.Right;
            tboxPrecoVenda.Leave += TboxPrecoVenda_Leave;
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImagem.Location = new Point(18, 264);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(142, 183);
            pictureBoxImagem.TabIndex = 20;
            pictureBoxImagem.TabStop = false;
            // 
            // btnEditarImagem
            // 
            btnEditarImagem.Location = new Point(167, 264);
            btnEditarImagem.Margin = new Padding(4);
            btnEditarImagem.Name = "btnEditarImagem";
            btnEditarImagem.Size = new Size(40, 36);
            btnEditarImagem.TabIndex = 21;
            btnEditarImagem.UseVisualStyleBackColor = true;
            // 
            // btnExcluirImagem
            // 
            btnExcluirImagem.Location = new Point(167, 301);
            btnExcluirImagem.Margin = new Padding(4);
            btnExcluirImagem.Name = "btnExcluirImagem";
            btnExcluirImagem.Size = new Size(40, 36);
            btnExcluirImagem.TabIndex = 22;
            btnExcluirImagem.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(826, 566);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(131, 32);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(964, 35);
            label1.TabIndex = 25;
            label1.Text = "Cadastro de Produto";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProdutoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 611);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(tboxEstoqueAtual);
            Controls.Add(label10);
            Controls.Add(tboxEstoqueMin);
            Controls.Add(btnExcluirImagem);
            Controls.Add(label5);
            Controls.Add(tboxPrecoVenda);
            Controls.Add(label8);
            Controls.Add(tboxCodigo);
            Controls.Add(label4);
            Controls.Add(tboxPrecoCusto);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(btnEditarImagem);
            Controls.Add(tboxCodigoFabrica);
            Controls.Add(tboxUnidadeMedida);
            Controls.Add(tboxCodigoBarra);
            Controls.Add(tboxDescricao);
            Controls.Add(pictureBoxImagem);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProdutoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += ProdutoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tboxCodigo;
        private TextBox tboxDescricao;
        private TextBox tboxCodigoBarra;
        private TextBox tboxCodigoFabrica;
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
        private Button btnSalvar;
        private Label label1;
    }
}