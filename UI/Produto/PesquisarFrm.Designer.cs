namespace UI.Produto
{
    partial class PesquisarFrm
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
            dgvResponse = new DataGridView();
            btnNovo = new Button();
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
            label1.Text = "Cadastro de Produto";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvResponse
            // 
            dgvResponse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResponse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvResponse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvResponse.BackgroundColor = SystemColors.ButtonHighlight;
            dgvResponse.BorderStyle = BorderStyle.None;
            dgvResponse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResponse.GridColor = SystemColors.Control;
            dgvResponse.Location = new Point(0, 146);
            dgvResponse.Name = "dgvResponse";
            dgvResponse.ReadOnly = true;
            dgvResponse.RowHeadersVisible = false;
            dgvResponse.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvResponse.RowTemplate.Height = 25;
            dgvResponse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResponse.Size = new Size(962, 462);
            dgvResponse.TabIndex = 13;
            dgvResponse.CellDoubleClick += DgvResponse_CellDoubleClick;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovo.Location = new Point(871, 107);
            btnNovo.Margin = new Padding(4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(91, 32);
            btnNovo.TabIndex = 25;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += BtnNovo_Click;
            // 
            // PesquisarFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 611);
            Controls.Add(btnNovo);
            Controls.Add(dgvResponse);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "PesquisarFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += PesquisarFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResponse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvResponse;
        private Button btnNovo;
    }
}