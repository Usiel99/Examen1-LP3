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
    public partial class Ejercicio1Form : Form
    {
        public Ejercicio1Form()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            double Ingreso = 200000.00;
            double Interes = 0.015;
            for (int mes = 1; mes <= 12; mes++) 
            {
                double InteresMensual = CalcularInteres(Ingreso, Interes, mes);
                listBox1.Items.Add($"El interés para el mes {mes} es: L {InteresMensual:F2}");
            }

        }



        private double CalcularInteres(double Ingreso, double Interes, int mes)
        {
            Ingreso = 200000.00;
            Interes = 0.015;
            double InteresMensual = (Ingreso) * (Interes) * (mes);
            return InteresMensual;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
