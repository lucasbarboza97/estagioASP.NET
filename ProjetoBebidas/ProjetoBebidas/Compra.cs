using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBebidas
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        // Carrega o datagrid com a lista de códigos de bebidas
        private void carregaListaDeCodigos()
        {
            dgCodigos.Rows.Clear();

            Style modelo = new Style();
            dgCodigos = modelo.styleDataGridView(dgCodigos);

            string codigo;
            string nome;

            dgCodigos.ColumnCount = 2;
            dgCodigos.Columns[0].Name = "Código";
            dgCodigos.Columns[1].Name = "Bebida";

            SqlConnection con = new SqlConnection();
            string sql = "SELECT codigo, nome FROM estoque_bebida";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.ConnectionString = Properties.Settings.Default.connectionString;
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        codigo = reader[0].ToString();
                        nome = reader[1].ToString();


                        dgCodigos.Rows.Add(codigo, nome);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        // Da o focus no text box codigo
        private void selecionaTxtCodigo()
        {
            txtCodigo.Text = "";
            txtCodigo.Focus();
        }

        // Carregamento do form Compra
        private void Compra_Load(object sender, EventArgs e)
        {
            lblDataCompra.Visible = false;
            lblTotal.Visible = false;
            lblTroco.Visible = false;

            txtCodigo.Enabled = false;
            txtBoxDinheiroRecebido.Enabled = false;
        }

        // Acionamento do botão realizar compra
        private void button1_Click_1(object sender, EventArgs e)
        {
            lstCarrinho.Items.Clear();

            txtCodigo.Enabled = true;
            txtBoxDinheiroRecebido.Enabled = true;

            lblDataCompra.Visible = false;
            lblTotal.Visible = false;
            lblTroco.Visible = false;

            carregaListaDeCodigos();
            selecionaTxtCodigo();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 3)
            {
                int indice = 0;
                for (int prod = 1; prod < codigo.Length; prod++)
                {
                    if (txtCodigo.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }

                if (indice == 0)
                {
                    MessageBox.Show("Produto não encontrado");

                }
                else
                {
                    
                }
            }
        }


    }
}
