using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BibliotecaHOW4
{
    public partial class Leitor : Form
    {
      
        public Leitor()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "howx";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "1234";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }
        //Inserir Leitor no Banco de dados
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO leitor (nome_leitor,email_leitor,cpf_leitor,telefone_leitor) " +
                    "VALUES ('" + tbnNome.Text + "', '" + tbnEmail.Text + "','" + tbnCpf.Text + "', '" + tbnTelefone.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizaGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        //Limpar dados apos inserir no Banco de dados      
        private void limparCampos()
        {
            tbnNome.Clear();
            tbnEmail.Clear();
            tbnTelefone.Clear();
            tbnCpf.Clear();
            tbnId.Clear();
            tbnStatus.Clear();
        }
        //Editar dados do Leitor
        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL

                comandoMySql.CommandText = " UPDATE leitor SET nome_leitor = '" + tbnNome.Text + "', " +
                            "email_leitor = '" + tbnEmail.Text + "', " +
                            "cpf_leitor = '" + tbnCpf.Text + "', " +
                            "telefone_leitor = '" + tbnTelefone.Text + "', " +
                            "status_leitor = " + Convert.ToInt16(tbnStatus.Text) +
                            " WHERE id_leitor = " + tbnId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close(); // Fecho a conexão com o banco

                MessageBox.Show("Atualizado com sucesso"); // Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistema temporariamente indisponível. Tente novamente mais tarde");
                Console.WriteLine(ex.Message);
            }
        }
        //Inativar dados do leitor do BD
        private void btnInativar_Click(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL              
                comandoMySql.CommandText = "UPDATE leitor SET status_leitor = 0 WHERE id_leitor = " + tbnId.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Inativado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistema temporariamente indisponível. Tente novamente mais tarde");
                Console.WriteLine(ex.Message);
            }
        }
        //Atuliza o grid 
        private void Leitor_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM leitor";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgLeitor.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgLeitor.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//EMAIL
                    row.Cells[3].Value = reader.GetString(3);//CPF
                    row.Cells[4].Value = reader.GetString(4);//TELEFONE
                    row.Cells[5].Value = reader.GetString(5);//Status

                    dgLeitor.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistema temporariamente indisponível. Tente novamente mais tarde");
                Console.WriteLine(ex.Message);
            }
        }
        
        private void dgLeitor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgLeitor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgLeitor.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tbnNome.Text = dgLeitor.Rows[e.RowIndex].Cells["colNome"].FormattedValue.ToString();
                tbnEmail.Text = dgLeitor.Rows[e.RowIndex].Cells["colEmail"].FormattedValue.ToString();
                tbnCpf.Text = dgLeitor.Rows[e.RowIndex].Cells["colCpf"].FormattedValue.ToString();
                tbnId.Text = dgLeitor.Rows[e.RowIndex].Cells["colId"].FormattedValue.ToString();
                tbnStatus.Text = dgLeitor.Rows[e.RowIndex].Cells["colStatus"].FormattedValue.ToString();
                tbnTelefone.Text = dgLeitor.Rows[e.RowIndex].Cells["ColTel"].FormattedValue.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
