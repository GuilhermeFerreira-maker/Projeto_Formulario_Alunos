using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscricoes
{
    public partial class Form1 : Form
    {
        private Alunos alunos;
        private Cursos cursos;
        private incricoes incricoes;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (alunos == null || alunos.IsDisposed)
                {
                    alunos = new Alunos(this); 
                    alunos.Show();
                    this.Hide(); 
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (cursos == null || cursos.IsDisposed)
                {
                    cursos = new Cursos(this);
                    cursos.Show();
                    this.Hide();
                }
            }
        }

            private void button3_Click(object sender, EventArgs e)
        {
            if (incricoes == null || incricoes.IsDisposed)
            {
                incricoes = new incricoes(this);
                incricoes.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                var resposta = MessageBox.Show("Deseja realmente sair da aplicação?",
                                               "Sair",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    Application.Exit(); // Encerra toda a aplicação
                }
            }
        }
    }
}

