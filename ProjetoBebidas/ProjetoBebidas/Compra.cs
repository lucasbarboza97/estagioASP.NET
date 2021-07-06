﻿using System;
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
        private string dataNow = DateTime.Now.ToString("dd'-'MM'-'yyyy");
        private double troco;
        private double soma;
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
            int estoque;

            dgCodigos.ColumnCount = 3;
            dgCodigos.Columns[0].Name = "Código";
            dgCodigos.Columns[1].Name = "Bebida";
            dgCodigos.Columns[2].Name = "Estoque";


            SqlConnection con = new SqlConnection();
            string sql = "SELECT codigo, nome, qtd FROM estoque_bebida";
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
                        estoque = Convert.ToInt32(reader[2].ToString());

                        dgCodigos.Rows.Add(codigo, nome, estoque);
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
            txtCodigo.Enabled = false;
            txtQtd.Enabled = false;
            txtDinheiro.Enabled = false;

            btnFinalizarCompra.Enabled = false;
            btnVerificarTroco.Enabled = false;
        }

        // Acionamento do botão realizar compra
        private void button1_Click_1(object sender, EventArgs e)
        {
            dgCarrinho.Rows.Clear();

            txtCodigo.Enabled = true;
            txtQtd.Enabled = true;

            carregaListaDeCodigos();
            selecionaTxtCodigo();

            lblDataCompra.Text = ("Data compra: " + dataNow);
        }

        // Botão para finalizar a compra e enviar os itens para o BD
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            string sql = "SELECT TOP 1 id FROM compra_bebida ORDER BY id DESC";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.ConnectionString = Properties.Settings.Default.connectionString;
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0].ToString());

                    SqlConnection conInsert = new SqlConnection();
                    string sqlInsert = "INSERT compra_bebida (id,data,valor,id_produto_compra) VALUES(" + id + "," + Convert.ToDateTime(lblDataCompra.Text) + ", " + soma + ", " + id + ")";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsert, conInsert);
                    conInsert.ConnectionString = Properties.Settings.Default.connectionString;
                    cmdInsert.CommandType = CommandType.Text;
                    conInsert.Open();
                    try
                    {

                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        // Botão para colocar itens no carrinho. Habilitado ao clicar em nova compra.
        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            Style modelo = new Style();
            dgCarrinho = modelo.styleDataGridView(dgCarrinho);
            dgCarrinho.ColumnCount = 3;
            dgCarrinho.Columns[0].Name = "Bebida";
            dgCarrinho.Columns[1].Name = "Quantidade";
            dgCarrinho.Columns[2].Name = "Preço";

            double preco;
            string bebida;
            int qtdCompra;
            int qtdEstoque;

            SqlConnection con = new SqlConnection();
            string sql = "SELECT nome, preco, qtd FROM estoque_bebida WHERE codigo = '" + txtCodigo.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.ConnectionString = Properties.Settings.Default.connectionString;
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bebida = reader[0].ToString();
                    qtdCompra = Convert.ToInt32(txtQtd.Text);
                    preco =  qtdCompra * Convert.ToDouble(reader[1].ToString());
                    qtdEstoque = Convert.ToInt32(reader[2].ToString());

                    if (Convert.ToInt32(txtQtd.Text) <= qtdEstoque)
                    {
                        dgCarrinho.Rows.Add(bebida, qtdCompra, preco);

                        for (int i = 0; i < dgCarrinho.Rows.Count; i++)
                        {
                            soma += Convert.ToDouble(dgCarrinho.Rows[i].Cells[2].Value.ToString());
                            lblTotal.Text = ("Valor total: R$" + soma);
                        }

                        txtDinheiro.Enabled = true;
                        btnVerificarTroco.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Quantidade de estoque indisponível. Essa bebida só tem " + qtdEstoque + " latas.");
                    }
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
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

        // Botão para verificar troco, só é habilitado quando um item é colocado no carrinho.
        private void btnVerificarTroco_Click(object sender, EventArgs e)
        {
            double dinheiroRecebido = Convert.ToDouble(txtDinheiro.Text);
            troco = dinheiroRecebido - soma;

            btnFinalizarCompra.Enabled = true;

            if (troco < 0)
            {
                lblTroco.Text = "Falta: R$" + (troco*(-1));
            }
            else if(dinheiroRecebido > soma)
            {
                lblTroco.Text = ("Troco: R$: " + (troco));
            }
            else
            {
                lblTroco.Text = ("Tudo certo!");
            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
