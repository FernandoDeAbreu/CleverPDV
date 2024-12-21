namespace UI
{
    partial class CategoriaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tboxCodigo = new TextBox();
            tboxDescricao = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dgvResponse = new DataGridView();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResponse).BeginInit();
            SuspendLayout();
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
            label1.TabIndex = 6;
            label1.Text = "Cadastro de categoria";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tboxCodigo
            // 
            tboxCodigo.BackColor = SystemColors.ButtonHighlight;
            tboxCodigo.Location = new Point(10, 60);
            tboxCodigo.Name = "tboxCodigo";
            tboxCodigo.ReadOnly = true;
            tboxCodigo.Size = new Size(125, 29);
            tboxCodigo.TabIndex = 8;
            // 
            // tboxDescricao
            // 
            tboxDescricao.Location = new Point(10, 112);
            tboxDescricao.MaxLength = 50;
            tboxDescricao.Name = "tboxDescricao";
            tboxDescricao.Size = new Size(801, 29);
            tboxDescricao.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 40);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 10;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 90);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 11;
            label3.Text = "Descrição";
            // 
            // dgvResponse
            // 
            dgvResponse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvResponse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvResponse.BackgroundColor = SystemColors.ButtonHighlight;
            dgvResponse.BorderStyle = BorderStyle.None;
            dgvResponse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResponse.GridColor = SystemColors.Control;
            dgvResponse.Location = new Point(3, 155);
            dgvResponse.Name = "dgvResponse";
            dgvResponse.ReadOnly = true;
            dgvResponse.RowHeadersVisible = false;
            dgvResponse.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvResponse.RowTemplate.Height = 25;
            dgvResponse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResponse.Size = new Size(957, 455);
            dgvResponse.TabIndex = 12;
            dgvResponse.CellClick += DgvResponse_CellClick;
            dgvResponse.KeyDown += DgvResponse_KeyDown;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(818, 106);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(146, 38);
            btnSalvar.TabIndex = 24;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_ClickAsync;
            // 
            // CategoriaForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 611);
            Controls.Add(label2);
            Controls.Add(btnSalvar);
            Controls.Add(dgvResponse);
            Controls.Add(tboxCodigo);
            Controls.Add(tboxDescricao);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CategoriaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += CategoriaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResponse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tboxCodigo;
        private TextBox tboxDescricao;
        private Label label2;
        private Label label3;
        private DataGridView dgvResponse;
        private Button btnSalvar;
    }
}