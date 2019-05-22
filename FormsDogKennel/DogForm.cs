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
    public partial class DogForm : Form
    {
        public DogForm( Dog dog)
        {
            Dog = dog;
            InitializeComponent();
        }

        public Dog Dog { get; set; }


        private void DogForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Dog.Breed;
            comboBox1.Text = Dog.Gender;
            dateTimePicker1.Text = Dog.DateOfBirth.ToLongDateString();
            textBox2.Text = Dog.CostInRubles;     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dog.Breed = textBox1.Text;
            Dog.Gender = comboBox1.Text;
            Dog.DateOfBirth = dateTimePicker1.Value;
            Dog.CostInRubles = textBox2.Text;
        }
    }
}
