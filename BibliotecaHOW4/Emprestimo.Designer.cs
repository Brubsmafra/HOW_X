
namespace BibliotecaHOW4
{
    partial class EmprestimoLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoLivro));
            this.IDsaida = new System.Windows.Forms.Label();
            this.CPFSaida = new System.Windows.Forms.Label();
            this.NomeSaida = new System.Windows.Forms.Label();
            this.telefoneSaida = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIDSaida = new System.Windows.Forms.TextBox();
            this.tbCPFsaida = new System.Windows.Forms.TextBox();
            this.tbNomeSaida = new System.Windows.Forms.TextBox();
            this.tbTelefoneSaida = new System.Windows.Forms.TextBox();
            this.tbDescricaoSaida = new System.Windows.Forms.TextBox();
            this.dtRetira = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtVolta = new System.Windows.Forms.DateTimePicker();
            this.dgEmprestimo = new System.Windows.Forms.DataGridView();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.btInclui = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dUpDLivro = new System.Windows.Forms.DomainUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtadeRetirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtadeRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // IDsaida
            // 
            this.IDsaida.AutoSize = true;
            this.IDsaida.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDsaida.Location = new System.Drawing.Point(12, 25);
            this.IDsaida.Name = "IDsaida";
            this.IDsaida.Size = new System.Drawing.Size(25, 21);
            this.IDsaida.TabIndex = 20;
            this.IDsaida.Text = "ID";
            this.IDsaida.UseMnemonic = false;
            // 
            // CPFSaida
            // 
            this.CPFSaida.AutoSize = true;
            this.CPFSaida.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFSaida.Location = new System.Drawing.Point(8, 195);
            this.CPFSaida.Name = "CPFSaida";
            this.CPFSaida.Size = new System.Drawing.Size(37, 21);
            this.CPFSaida.TabIndex = 21;
            this.CPFSaida.Text = "CPF";
            // 
            // NomeSaida
            // 
            this.NomeSaida.AutoSize = true;
            this.NomeSaida.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeSaida.Location = new System.Drawing.Point(97, 154);
            this.NomeSaida.Name = "NomeSaida";
            this.NomeSaida.Size = new System.Drawing.Size(48, 21);
            this.NomeSaida.TabIndex = 22;
            this.NomeSaida.Text = "Leitor";
            // 
            // telefoneSaida
            // 
            this.telefoneSaida.AutoSize = true;
            this.telefoneSaida.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneSaida.Location = new System.Drawing.Point(335, 197);
            this.telefoneSaida.Name = "telefoneSaida";
            this.telefoneSaida.Size = new System.Drawing.Size(67, 21);
            this.telefoneSaida.TabIndex = 23;
            this.telefoneSaida.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Observação";
            // 
            // tbIDSaida
            // 
            this.tbIDSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDSaida.Location = new System.Drawing.Point(51, 22);
            this.tbIDSaida.Name = "tbIDSaida";
            this.tbIDSaida.Size = new System.Drawing.Size(40, 24);
            this.tbIDSaida.TabIndex = 25;
            // 
            // tbCPFsaida
            // 
            this.tbCPFsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPFsaida.Location = new System.Drawing.Point(51, 194);
            this.tbCPFsaida.Name = "tbCPFsaida";
            this.tbCPFsaida.Size = new System.Drawing.Size(214, 24);
            this.tbCPFsaida.TabIndex = 26;
            // 
            // tbNomeSaida
            // 
            this.tbNomeSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeSaida.Location = new System.Drawing.Point(145, 151);
            this.tbNomeSaida.Name = "tbNomeSaida";
            this.tbNomeSaida.Size = new System.Drawing.Size(488, 24);
            this.tbNomeSaida.TabIndex = 27;
            // 
            // tbTelefoneSaida
            // 
            this.tbTelefoneSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefoneSaida.Location = new System.Drawing.Point(419, 194);
            this.tbTelefoneSaida.Name = "tbTelefoneSaida";
            this.tbTelefoneSaida.Size = new System.Drawing.Size(214, 24);
            this.tbTelefoneSaida.TabIndex = 28;
            // 
            // tbDescricaoSaida
            // 
            this.tbDescricaoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricaoSaida.Location = new System.Drawing.Point(339, 273);
            this.tbDescricaoSaida.Multiline = true;
            this.tbDescricaoSaida.Name = "tbDescricaoSaida";
            this.tbDescricaoSaida.Size = new System.Drawing.Size(294, 78);
            this.tbDescricaoSaida.TabIndex = 29;
            // 
            // dtRetira
            // 
            this.dtRetira.Location = new System.Drawing.Point(16, 274);
            this.dtRetira.Name = "dtRetira";
            this.dtRetira.Size = new System.Drawing.Size(249, 20);
            this.dtRetira.TabIndex = 32;
            this.dtRetira.ValueChanged += new System.EventHandler(this.dtRetira_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Data de Retirada";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data de Retorno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtVolta
            // 
            this.dtVolta.Location = new System.Drawing.Point(22, 331);
            this.dtVolta.Name = "dtVolta";
            this.dtVolta.Size = new System.Drawing.Size(243, 20);
            this.dtVolta.TabIndex = 35;
            this.dtVolta.ValueChanged += new System.EventHandler(this.dtVolta_ValueChanged);
            // 
            // dgEmprestimo
            // 
            this.dgEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNome,
            this.ColLivro,
            this.ColDtadeRetirada,
            this.ColDtadeRetorno,
            this.ColObs});
            this.dgEmprestimo.Location = new System.Drawing.Point(0, 372);
            this.dgEmprestimo.Name = "dgEmprestimo";
            this.dgEmprestimo.Size = new System.Drawing.Size(884, 203);
            this.dgEmprestimo.TabIndex = 54;
            this.dgEmprestimo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btPesquisa
            // 
            this.btPesquisa.BackColor = System.Drawing.Color.LightCyan;
            this.btPesquisa.BackgroundImage = global::BibliotecaHOW4.Properties.Resources.seo;
            this.btPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisa.Location = new System.Drawing.Point(826, 15);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(47, 45);
            this.btPesquisa.TabIndex = 56;
            this.btPesquisa.UseVisualStyleBackColor = false;
            // 
            // btInclui
            // 
            this.btInclui.BackColor = System.Drawing.Color.LightCyan;
            this.btInclui.BackgroundImage = global::BibliotecaHOW4.Properties.Resources.add_file;
            this.btInclui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInclui.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btInclui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInclui.Location = new System.Drawing.Point(762, 15);
            this.btInclui.Name = "btInclui";
            this.btInclui.Size = new System.Drawing.Size(46, 51);
            this.btInclui.TabIndex = 55;
            this.btInclui.UseVisualStyleBackColor = false;
            this.btInclui.Click += new System.EventHandler(this.btInclui_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Livro";
            // 
            // dUpDLivro
            // 
            this.dUpDLivro.Location = new System.Drawing.Point(145, 27);
            this.dUpDLivro.Name = "dUpDLivro";
            this.dUpDLivro.Size = new System.Drawing.Size(488, 20);
            this.dUpDLivro.TabIndex = 58;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(101, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 24);
            this.textBox1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Autor(a)";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 62;
            this.label6.Text = "Editora";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(101, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 24);
            this.textBox2.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 64;
            this.label7.Text = "Categoria";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(419, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 24);
            this.textBox3.TabIndex = 63;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(51, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 24);
            this.textBox4.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 21);
            this.label8.TabIndex = 65;
            this.label8.Text = "ID";
            this.label8.UseMnemonic = false;
            // 
            // ColID
            // 
            this.ColID.FillWeight = 10F;
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.Width = 50;
            // 
            // ColNome
            // 
            this.ColNome.FillWeight = 200F;
            this.ColNome.HeaderText = "Livro";
            this.ColNome.Name = "ColNome";
            this.ColNome.Width = 250;
            // 
            // ColLivro
            // 
            this.ColLivro.FillWeight = 200F;
            this.ColLivro.HeaderText = "Leitor";
            this.ColLivro.Name = "ColLivro";
            this.ColLivro.Width = 250;
            // 
            // ColDtadeRetirada
            // 
            this.ColDtadeRetirada.FillWeight = 20F;
            this.ColDtadeRetirada.HeaderText = "Data de Retirada";
            this.ColDtadeRetirada.Name = "ColDtadeRetirada";
            this.ColDtadeRetirada.Width = 80;
            // 
            // ColDtadeRetorno
            // 
            this.ColDtadeRetorno.FillWeight = 20F;
            this.ColDtadeRetorno.HeaderText = "Data de Retorno";
            this.ColDtadeRetorno.Name = "ColDtadeRetorno";
            this.ColDtadeRetorno.Width = 80;
            // 
            // ColObs
            // 
            this.ColObs.FillWeight = 350F;
            this.ColObs.HeaderText = "Observação";
            this.ColObs.Name = "ColObs";
            this.ColObs.Width = 300;
            // 
            // EmprestimoLivro
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(885, 575);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dUpDLivro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btPesquisa);
            this.Controls.Add(this.btInclui);
            this.Controls.Add(this.dgEmprestimo);
            this.Controls.Add(this.dtVolta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtRetira);
            this.Controls.Add(this.tbDescricaoSaida);
            this.Controls.Add(this.tbTelefoneSaida);
            this.Controls.Add(this.tbNomeSaida);
            this.Controls.Add(this.tbCPFsaida);
            this.Controls.Add(this.tbIDSaida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefoneSaida);
            this.Controls.Add(this.NomeSaida);
            this.Controls.Add(this.CPFSaida);
            this.Controls.Add(this.IDsaida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmprestimoLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saída de Livro";
            this.Load += new System.EventHandler(this.EmprestimoLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDsaida;
        private System.Windows.Forms.Label CPFSaida;
        private System.Windows.Forms.Label NomeSaida;
        private System.Windows.Forms.Label telefoneSaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIDSaida;
        private System.Windows.Forms.TextBox tbCPFsaida;
        private System.Windows.Forms.TextBox tbNomeSaida;
        private System.Windows.Forms.TextBox tbTelefoneSaida;
        private System.Windows.Forms.TextBox tbDescricaoSaida;
        private System.Windows.Forms.DateTimePicker dtRetira;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtVolta;
        private System.Windows.Forms.DataGridView dgEmprestimo;
        private System.Windows.Forms.Button btInclui;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown dUpDLivro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtadeRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtadeRetorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObs;
    }
}