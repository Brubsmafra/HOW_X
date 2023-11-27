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
   
    public partial class EmprestimoLivro : Form
    {
        public EmprestimoLivro()
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
              
        private void EmprestimoLivro_Load(object sender, EventArgs e)
        {

        }

        private void btInclui_Click(object sender, EventArgs e)//criar reserva
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO emprestimo (tbIDSaida,tbCPFsaida,tbNomeSaida,tbTelefoneSaida,tbEmailSaida,tbDescricaoSaida,dtRetira,dtVolta,dUpDLivro) " +
                    "VALUES ('" + tbCPFsaida.Text + "', '" + tbIDSaida.Text + "', '" + tbNomeSaida.Text + "', '" + tbTelefoneSaida.Text + "','" + tbDescricaoSaida.Text + "','" + dtRetira.Text + "','" + dtVolta.Text + "','" +dUpDLivro.Text +"')";
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
      
        private void limparCampos()
        {
            throw new NotImplementedException();
        }

       
        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM Emprestimo WHERE statusEmprestimo = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgEmprestimo.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgEmprestimo.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//CPF
                    row.Cells[3].Value = reader.GetString(3);//EMAIL
                    row.Cells[4].Value = reader.GetString(4);//TELEFONE
                    row.Cells[5].Value = reader.GetString(5);//LIVRO
                    row.Cells[5].Value = reader.GetString(6);//STATUS


                    dgEmprestimo.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEmprestimo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgEmprestimo.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tbNomeSaida.Text = dgEmprestimo.Rows[e.RowIndex].Cells["colNome"].FormattedValue.ToString();
                tbCPFsaida.Text = dgEmprestimo.Rows[e.RowIndex].Cells["colCpf"].FormattedValue.ToString();
                tbIDSaida.Text = dgEmprestimo.Rows[e.RowIndex].Cells["colId"].FormattedValue.ToString();           
                tbTelefoneSaida.Text = dgEmprestimo.Rows[e.RowIndex].Cells["ColTel"].FormattedValue.ToString();
                dUpDLivro.Text = dgEmprestimo.Rows[e.RowIndex].Cells["ColLivro"].FormattedValue.ToString();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dtRetira_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtVolta_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
