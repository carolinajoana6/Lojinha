using Lojinha.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojinha.Formularios
{
    public partial class BuscaClientesForm : Form
    {
        public BuscaClientesForm()
        {
            InitializeComponent();
        }
        public void AtualizaGrid()
        {
            // Comunicação com a camada BLL
            ClientesBLL obj = new ClientesBLL();
            ClientesDataGridView.DataSource = obj.Listagem(filtroTexBox.Text);

            //atualiza os objetos TextBox
            try
            {
                codigoTextBox.Text = ClientesDataGridView[0, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = ClientesDataGridView[1, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                emailTextBox.Text = ClientesDataGridView[2, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                telefoneTextBox.Text = ClientesDataGridView[3, ClientesDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                emailTextBox.Text = "";
                telefoneTextBox.Text = "";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscaClientesForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            nomeTextBox.Focus();
        }

        private void FiltrarButon_Click(object sender, EventArgs e)
        {
            // Comunicação com a camada BLL
            ClientesBLL obj = new ClientesBLL();
            ClientesDataGridView.DataSource = obj.Listagem(filtroTexBox.Text);

            //atualiza os objetos TextBox
            try
            {
                codigoTextBox.Text = ClientesDataGridView[0, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = ClientesDataGridView[1, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                emailTextBox.Text = ClientesDataGridView[2, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                telefoneTextBox.Text = ClientesDataGridView[3, ClientesDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                emailTextBox.Text = "";
                telefoneTextBox.Text = "";
            }
        }
    }
}
