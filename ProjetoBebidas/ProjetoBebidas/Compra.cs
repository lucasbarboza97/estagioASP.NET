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
            carregaArray();

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


        // Carrega array para acrescentar no "carrinho" de compras
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        private void carregaArray()
        {

            SqlConnection conSelect = new SqlConnection();
            string sql = "SELECT codigo, nome, preco, qtd FROM estoque_bebida";
            SqlCommand cmd = new SqlCommand(sql, conSelect);
            conSelect.ConnectionString = Properties.Settings.Default.connectionString;
            cmd.CommandType = CommandType.Text;
            SqlDataReader readerSelect;
            conSelect.Open();

            try
            {
                readerSelect = cmd.ExecuteReader();
                if (readerSelect.HasRows)
                {
                    int indice = 0;
                    while (readerSelect.Read())
                    {
                        codigo[indice] = readerSelect[0].ToString();
                        produtos[indice] = readerSelect[1].ToString();
                        valor[indice] = Convert.ToDouble(readerSelect[2].ToString());
                        indice++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conSelect.Close();
            }
        }


        double soma;
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Visible = true;
            txtBoxDinheiroRecebido.Enabled = true;
            if (txtCodigo.Text.Length == 3)
            {
                int indice = 0;
                for (int prod = 0; prod < codigo.Length; prod++)
                {
                    if (txtCodigo.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }
                if (indice == 0)
                {
                    MessageBox.Show("Produto não encontrado: ");

                }
                else
                {
                    lstCarrinho.Items.Add(txtCodigo.Text + " -- " + produtos[indice] + "--R$" + valor[indice]);

                    soma += valor[indice];
                    lblTotal.Text = ("R$ " + soma);
                    selecionaTxtCodigo();
                }

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            for (int i = 0; i < codigo.Length; i++)
            {
                MessageBox.Show(codigo[i] + produtos[i] + valor[i]);
            }
        }
    }
}
