using DogKennel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FormsDogKennel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dog = new DogForm(new Dog { DateOfBirth = DateTime.Now });
            if (dog.ShowDialog(this) == DialogResult.OK)
            {
                listBox1.Items.Add(dog.Dog);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled = listBox1.SelectedItem is Dog;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var item = (Dog)listBox1.Items[index];
                var ff = new DogForm(item);
                if (ff.ShowDialog(this) == DialogResult.OK)
                {
                    listBox1.Items.Remove(item);
                    listBox1.Items.Insert(index, item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Dog)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm() { Employee = new Employee() };
            if (employeeForm.ShowDialog(this) == DialogResult.OK)
            {
                listBox2.Items.Add(employeeForm.Employee);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is Employee)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox2.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var item = (Employee)listBox1.Items[index];
                var ff = new EmployeeForm() { Employee = item };
                if (ff.ShowDialog(this) == DialogResult.OK)
                {
                    listBox2.Items.Remove(item);
                    listBox2.Items.Insert(index, item);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = listBox2.SelectedItem is Employee;
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Питомник|*.dogs" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;
            var xs = new XmlSerializer(typeof(KennelOfDog));
            var file = File.OpenRead(ofd.FileName);
            var kennel = (KennelOfDog)xs.Deserialize(file);
            file.Close();

            textBox1.Text = kennel.Name;

            var ms = new MemoryStream(kennel.Photo);
            pictureBox1.Image = Image.FromStream(ms);

            textBox2.Text = kennel.Address;

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (var dog in kennel.Dog)
            {
                listBox1.Items.Add(dog);
            }
            foreach (var employee in kennel.Employee)
            {
                listBox2.Items.Add(employee);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Питомник|*.dogs" };

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;

            var kennel = new KennelOfDog()
            {
                Name = textBox1.Text,
                Address = textBox2.Text,
                Dog = listBox1.Items.OfType<Dog>().ToList(),
                Employee = listBox2.Items.OfType<Employee>().ToList()
            };

            var stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            kennel.Photo = stream.ToArray();

            var xs = new XmlSerializer(typeof(KennelOfDog));

            var file = File.Create(sfd.FileName);

            xs.Serialize(file, kennel);
            file.Close();
        }
    }
}
