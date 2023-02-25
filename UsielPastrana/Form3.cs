using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsielPastrana
{
    public partial class Ejercicio3Form : Form
    {
        public Ejercicio3Form()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            MuestraNumeros();
        }
        private void MuestraNumeros()
        {
            for (int i=1; i<=100; i++)
            {
                if (i%3==0 && i % 5 == 0)
                {
                    listBox1.Items.Add(i +" Usiel Pastrana");
                }
                else if (i % 3 == 0)
                {
                    listBox1.Items.Add(i +" Usiel");
                }
                else if (i % 5 == 0)
                {
                    listBox1.Items.Add(i +" Pastrana");
                }
                else
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
