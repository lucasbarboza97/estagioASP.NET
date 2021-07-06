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
    public partial class Vendas : Form
    {
        double valorTotal;

        public Vendas()
        {
            InitializeComponent();
        }

        // Carrega o datagrid com todas as vendas listadas no DB
        private void carregaVendas()
        {
            dataGridView1.Rows.Clear();

            Style modelo = new Style();
            dataGridView1 = modelo.styleDataGridView(dataGridView1);
            string dataVenda;
            int qtd;
            double valorVenda;

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Data Venda";
            dataGridView1.Columns[1].Name = "Quantidade";
            dataGridView1.Columns[2].Name = "Valor total";

            SqlConnection con = new SqlConnection();
            string sql = "SELECT data_compra,qtd_compra,valor FROM compra_bebida";
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
                        dataVenda = reader[0].ToString();
                        qtd = Convert.ToInt32(reader[1].ToString());
                        valorVenda = Convert.ToDouble(reader[2].ToString());

                        dataGridView1.Rows.Add(dataVenda,qtd, valorVenda);
                        valorTotal += valorVenda;
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

        private void Vendas_Load(object sender, EventArgs e)
        {
            carregaVendas();
            lblValorTotal.Text = "Valor total das vendas: " + valorTotal;
        }
    }
}
