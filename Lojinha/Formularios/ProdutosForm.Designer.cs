namespace Lojinha.Formularios
{
    partial class ProdutosForm
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
            this.Incluirbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Alterarbutton = new System.Windows.Forms.Button();
            this.Excluirbutton = new System.Windows.Forms.Button();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.preçoTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Incluirbutton
            // 
            this.Incluirbutton.Location = new System.Drawing.Point(36, 306);
            this.Incluirbutton.Name = "Incluirbutton";
            this.Incluirbutton.Size = new System.Drawing.Size(75, 23);
            this.Incluirbutton.TabIndex = 0;
            this.Incluirbutton.Text = "Incluir";
            this.Incluirbutton.UseVisualStyleBackColor = true;
            this.Incluirbutton.Click += new System.EventHandler(this.Incluirbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estoque:";
            // 
            // Alterarbutton
            // 
            this.Alterarbutton.Location = new System.Drawing.Point(183, 306);
            this.Alterarbutton.Name = "Alterarbutton";
            this.Alterarbutton.Size = new System.Drawing.Size(75, 23);
            this.Alterarbutton.TabIndex = 5;
            this.Alterarbutton.Text = "Alterar";
            this.Alterarbutton.UseVisualStyleBackColor = true;
            // 
            // Excluirbutton
            // 
            this.Excluirbutton.Location = new System.Drawing.Point(344, 306);
            this.Excluirbutton.Name = "Excluirbutton";
            this.Excluirbutton.Size = new System.Drawing.Size(75, 23);
            this.Excluirbutton.TabIndex = 6;
            this.Excluirbutton.Text = "Excluir";
            this.Excluirbutton.UseVisualStyleBackColor = true;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(128, 39);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(216, 20);
            this.codigoTextBox.TabIndex = 7;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(128, 97);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(216, 20);
            this.nomeTextBox.TabIndex = 8;
            // 
            // preçoTextBox
            // 
            this.preçoTextBox.Location = new System.Drawing.Point(128, 142);
            this.preçoTextBox.Name = "preçoTextBox";
            this.preçoTextBox.Size = new System.Drawing.Size(216, 20);
            this.preçoTextBox.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 192);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(216, 20);
            this.textBox4.TabIndex = 10;
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 433);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.preçoTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.Excluirbutton);
            this.Controls.Add(this.Alterarbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Incluirbutton);
            this.Name = "ProdutosForm";
            this.Text = "ProdutosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Incluirbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Alterarbutton;
        private System.Windows.Forms.Button Excluirbutton;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox preçoTextBox;
        private System.Windows.Forms.TextBox textBox4;
    }
}