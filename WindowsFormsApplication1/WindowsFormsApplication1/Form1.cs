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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Benefits". При необходимости она может быть перемещена или удалена.
            this.benefitsTableAdapter.Fill(this.hostelDataSet.Benefits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.hostelDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.hostelDataSet.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet5.Студенты". При необходимости она может быть перемещена или удалена.
            //this.студентыTableAdapter1.Fill(this.database1DataSet5.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet5.Льготы". При необходимости она может быть перемещена или удалена.
           // this.льготыTableAdapter1.Fill(this.database1DataSet5.Льготы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet5.Комнаты". При необходимости она может быть перемещена или удалена.
            //this.комнатыTableAdapter1.Fill(this.database1DataSet5.Комнаты);
            dataGridView1.AutoGenerateColumns = true;
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
            /*комнатыTableAdapter1.Update(database1DataSet5);
            студентыTableAdapter1.Update(database1DataSet5);
            льготыTableAdapter1.Update(database1DataSet5);*/
            roomsTableAdapter.Update(hostelDataSet);
            benefitsTableAdapter.Update(hostelDataSet);
            studentsTableAdapter.Update(hostelDataSet);
        }

        private void roomsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = roomsBindingSource;
            dataGridView1.DataSource = roomsBindingSource;
            label1.Text = "Rooms";
        }

        private void benefitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = benefitsBindingSource1;
            dataGridView1.DataSource = benefitsBindingSource1;
            label1.Text = "Benefits";
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = studentsBindingSource1;
            dataGridView1.DataSource = studentsBindingSource1;
            label1.Text = "Students";
        }

        private void resettlementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new RSForm();
            rs.ShowDialog();
            benefitsTableAdapter.Fill(hostelDataSet.Benefits);
            studentsTableAdapter.Fill(hostelDataSet.Students);
            roomsTableAdapter.Fill(hostelDataSet.Rooms);
        }
      
    }
}
