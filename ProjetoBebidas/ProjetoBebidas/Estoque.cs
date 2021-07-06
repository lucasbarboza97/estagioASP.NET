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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }
        // Classe de carregamento do form
        private void Estoque_Load(object sender, EventArgs e)
        {
            carregaDataGrid();
        }

        // Classe para carregar itens no data grid do form estoque
        private void carregaDataGrid()
        {
            dataGridView1.Rows.Clear();

            Style modelo = new Style();
            dataGridView1 = modelo.styleDataGridView(dataGridView1);
            string codigo;
            string nome;
            string preco;
            string qtd;

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Bebida";
            dataGridView1.Columns[2].Name = "Preço";
            dataGridView1.Columns[3].Name = "Quantidade";

            SqlConnection con = new SqlConnection();
            string sql = "SELECT codigo, nome, preco, qtd FROM estoque_bebida";
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
                        preco = "R$ " + reader[2].ToString();
                        qtd = reader[3].ToString();

                        dataGridView1.Rows.Add(codigo, nome, preco, qtd);
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

        // Evento que seleciona um item no data grid e altera o label "lblBebida" com o nome da bebida selecionado.
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string nomeSelecionado = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblBebida.Text = nomeSelecionado;
        }

        // Clique do botão add estoque, realiza um update na tabela estoque_bebida com o valor desejado contido no combobox.
        private void btdAddEstoque_Click(object sender, EventArgs e)
        {
            int qtd = Convert.ToInt32(txtAddEstoque.Text);
            string bebida = Convert.ToString(lblBebida.Text);
            int qtdEstoqueAnterior;
            int qtdEstoqueSomado;

            SqlConnection con = new SqlConnection();
            string sqlQtd = "SELECT qtd FROM estoque_bebida WHERE nome='" + bebida + "'";
            SqlCommand cmdQtd = new SqlCommand(sqlQtd, con);
            SqlDataReader reader;
            con.ConnectionString = Properties.Settings.Default.connectionString;
            con.Open();
            try
            {
                reader = cmdQtd.ExecuteReader();
                if (reader.Read())
                {
                    qtdEstoqueAnterior = Convert.ToInt32(reader[0].ToString());
                    qtdEstoqueSomado = qtdEstoqueAnterior + qtd;

                    SqlConnection conUp = new SqlConnection();
                    string sqlUpdate = "UPDATE estoque_bebida SET qtd=" + qtdEstoqueSomado + "WHERE nome='" + bebida + "'";
                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conUp);
                    cmdUpdate.CommandType = CommandType.Text;
                    conUp.ConnectionString = Properties.Settings.Default.connectionString;
                    conUp.Open();

                    try
                    {
                        int i = cmdUpdate.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Acrescentado " + qtd + " latas de: " + bebida);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                        conUp.Close();
                        carregaDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                throw ex;
            }

        }

        // Clique do botão rmv estoque, realiza um update na tabela estoque_bebida com o valor desejado contido no combobox.
        private void btdRmvEstoque_Click(object sender, EventArgs e)
        {
            int qtd = Convert.ToInt32(txtRmvEstoque.Text);
            string bebida = Convert.ToString(lblBebida.Text);
            int qtdEstoqueAnterior;
            int qtdEstoqueSubtraido;

            SqlConnection con = new SqlConnection();
            string sqlQtd = "SELECT qtd FROM estoque_bebida WHERE nome='" + bebida + "'";
            SqlCommand cmdQtd = new SqlCommand(sqlQtd, con);
            SqlDataReader reader;
            con.ConnectionString = Properties.Settings.Default.connectionString;
            con.Open();
            try
            {
                reader = cmdQtd.ExecuteReader();
                if (reader.Read())
                {
                    qtdEstoqueAnterior = Convert.ToInt32(reader[0].ToString());
                    if(qtd <= qtdEstoqueAnterior)
                    {

                        qtdEstoqueSubtraido = qtd - qtdEstoqueAnterior;

                        SqlConnection conUp = new SqlConnection();
                        string sqlUpdate = "UPDATE estoque_bebida SET qtd=" + qtdEstoqueSubtraido + "WHERE nome='" + bebida + "'";
                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conUp);
                        cmdUpdate.CommandType = CommandType.Text;
                        conUp.ConnectionString = Properties.Settings.Default.connectionString;
                        conUp.Open();

                        try
                        {
                            int i = cmdUpdate.ExecuteNonQuery();
                            if (i > 0)
                                MessageBox.Show("Removido " + qtd + " latas de: " + bebida);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex.ToString());
                        }
                        finally
                        {
                            con.Close();
                            conUp.Close();
                            carregaDataGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("A quantidade de itens para remoção deve ser de até: " + qtdEstoqueAnterior);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {

                con.Close();
            }
        }

        private void lblBebida_Click(object sender, EventArgs e)
        {

        }
    }
}
