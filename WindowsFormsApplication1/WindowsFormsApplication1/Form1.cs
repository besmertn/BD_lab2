using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet5.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter1.Fill(this.database1DataSet5.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet5.Льготы". При необходимости она может быть перемещена или удалена.
            this.льготыTableAdapter1.Fill(this.database1DataSet5.Льготы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet5.Комнаты". При необходимости она может быть перемещена или удалена.
            this.комнатыTableAdapter1.Fill(this.database1DataSet5.Комнаты);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            комнатыTableAdapter1.Update(database1DataSet5);
            студентыTableAdapter1.Update(database1DataSet5);
            льготыTableAdapter1.Update(database1DataSet5);
        }
    }
}
