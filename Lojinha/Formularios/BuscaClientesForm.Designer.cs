namespace Lojinha.Formularios
{
    partial class BuscaClientesForm
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
            this.codigolabel = new System.Windows.Forms.Label();
            this.nomelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LimparButton = new System.Windows.Forms.Button();
            this.IncluirButton = new System.Windows.Forms.Button();
            this.AlterarButton = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.ClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrarButon = new System.Windows.Forms.Button();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.filtroTexBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigolabel
            // 
            this.codigolabel.AutoSize = true;
            this.codigolabel.Enabled = false;
            this.codigolabel.Location = new System.Drawing.Point(72, 35);
            this.codigolabel.Name = "codigolabel";
            this.codigolabel.Size = new System.Drawing.Size(43, 13);
            this.codigolabel.TabIndex = 0;
            this.codigolabel.Text = "Código:";
            this.codigolabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomelabel
            // 
            this.nomelabel.AutoSize = true;
            this.nomelabel.Location = new System.Drawing.Point(72, 76);
            this.nomelabel.Name = "nomelabel";
            this.nomelabel.Size = new System.Drawing.Size(38, 13);
            this.nomelabel.TabIndex = 1;
            this.nomelabel.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // LimparButton
            // 
            this.LimparButton.Location = new System.Drawing.Point(60, 251);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(75, 23);
            this.LimparButton.TabIndex = 4;
            this.LimparButton.Text = "Limpar";
            this.LimparButton.UseVisualStyleBackColor = true;
            // 
            // IncluirButton
            // 
            this.IncluirButton.Location = new System.Drawing.Point(208, 251);
            this.IncluirButton.Name = "IncluirButton";
            this.IncluirButton.Size = new System.Drawing.Size(75, 23);
            this.IncluirButton.TabIndex = 5;
            this.IncluirButton.Text = "Incluir";
            this.IncluirButton.UseVisualStyleBackColor = true;
            // 
            // AlterarButton
            // 
            this.AlterarButton.Location = new System.Drawing.Point(354, 251);
            this.AlterarButton.Name = "AlterarButton";
            this.AlterarButton.Size = new System.Drawing.Size(75, 23);
            this.AlterarButton.TabIndex = 6;
            this.AlterarButton.Text = "Alterar";
            this.AlterarButton.UseVisualStyleBackColor = true;
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Location = new System.Drawing.Point(501, 251);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.ExcluirButton.TabIndex = 7;
            this.ExcluirButton.Text = "Excluir";
            this.ExcluirButton.UseVisualStyleBackColor = true;
            // 
            // ClientesDataGridView
            // 
            this.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDataGridView.Location = new System.Drawing.Point(38, 293);
            this.ClientesDataGridView.Name = "ClientesDataGridView";
            this.ClientesDataGridView.Size = new System.Drawing.Size(587, 182);
            this.ClientesDataGridView.TabIndex = 8;
            // 
            // FiltrarButon
            // 
            this.FiltrarButon.Location = new System.Drawing.Point(523, 481);
            this.FiltrarButon.Name = "FiltrarButon";
            this.FiltrarButon.Size = new System.Drawing.Size(75, 23);
            this.FiltrarButon.TabIndex = 9;
            this.FiltrarButon.Text = "Filtrar";
            this.FiltrarButon.UseVisualStyleBackColor = true;
            this.FiltrarButon.Click += new System.EventHandler(this.FiltrarButon_Click);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(194, 28);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(150, 20);
            this.codigoTextBox.TabIndex = 10;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(194, 69);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(150, 20);
            this.nomeTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(194, 112);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(150, 20);
            this.emailTextBox.TabIndex = 12;
            this.emailTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(194, 155);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(150, 20);
            this.telefoneTextBox.TabIndex = 13;
            // 
            // filtroTexBox
            // 
            this.filtroTexBox.Location = new System.Drawing.Point(38, 483);
            this.filtroTexBox.Name = "filtroTexBox";
            this.filtroTexBox.Size = new System.Drawing.Size(451, 20);
            this.filtroTexBox.TabIndex = 14;
            // 
            // BuscaClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 532);
            this.Controls.Add(this.filtroTexBox);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.FiltrarButon);
            this.Controls.Add(this.ClientesDataGridView);
            this.Controls.Add(this.ExcluirButton);
            this.Controls.Add(this.AlterarButton);
            this.Controls.Add(this.IncluirButton);
            this.Controls.Add(this.LimparButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomelabel);
            this.Controls.Add(this.codigolabel);
            this.Name = "BuscaClientesForm";
            this.Text = "BuscaClientesForm";
            this.Load += new System.EventHandler(this.BuscaClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigolabel;
        private System.Windows.Forms.Label nomelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LimparButton;
        private System.Windows.Forms.Button IncluirButton;
        private System.Windows.Forms.Button AlterarButton;
        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.DataGridView ClientesDataGridView;
        private System.Windows.Forms.Button FiltrarButon;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox filtroTexBox;
    }
}