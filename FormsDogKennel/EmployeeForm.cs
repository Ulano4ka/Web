using DogKennel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDogKennel
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        public Employee Employee { get; set; }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Employee.LastName;
            textBox2.Text = Employee.FirstName;
            textBox3.Text = Employee.Post;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee.LastName = textBox1.Text;
            Employee.FirstName = textBox2.Text;
            Employee.Post = textBox3.Text;
        }
    }
}
