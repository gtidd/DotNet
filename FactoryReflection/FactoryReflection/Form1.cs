using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryReflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dogBtn_Click(object sender, EventArgs e)
        {
            var dog = AnimalFactory.CreateAnimal("Dog");

            outputLbl.Text= string.Format(dog.Message);

        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            var cat = AnimalFactory.CreateAnimal("Cat");

            outputLbl.Text = string.Format(cat.Message);
        }

        private void foxBtn_Click(object sender, EventArgs e)
        {
            var fox = AnimalFactory.CreateAnimal("Fox");

            outputLbl.Text = string.Format(fox.Message);
        }
    }
}
