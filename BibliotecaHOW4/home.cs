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
using System.Threading;

namespace BibliotecaHOW4
{
    public partial class home : Form
    {
        Thread nt;
        public home()
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

     
    private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            nt = new Thread(logCadastro);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void logCadastro()
        {
            Application.Run(new CadastroLivro());
        }

        private void manutençãoAlterarInativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            nt = new Thread(logmanutenao);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void logmanutenao()
        {
            Application.Run(new manutencao());
        }

        private void cadastarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            nt = new Thread(logLeitor);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void logLeitor()
        {
            Application.Run (new Leitor());
        }

        private void estoqueDeLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            nt = new Thread(start: logEstoque);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void logEstoque()
        {
            Application.Run(new Estoque());
        }
     

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            nt = new Thread(logRetirada);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void logRetirada()
        {
            Application.Run(new EmprestimoLivro());
        }

        private void retornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            nt = new Thread(logRetorno);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void logRetorno()
        {
            Application.Run(new RetornoLivro());
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
