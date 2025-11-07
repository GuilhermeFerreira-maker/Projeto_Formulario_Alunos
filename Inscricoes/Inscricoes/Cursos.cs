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
    public partial class Cursos : Form
    {
        public Cursos(Form1 form1)
        {
            InitializeComponent();
        }

        private void cursoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Curso'. Você pode movê-la ou removê-la conforme necessário.
            this.cursoTableAdapter.Fill(this.database1DataSet.Curso);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}
