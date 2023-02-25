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
    public partial class Ejercicio2Form : Form
    {
        public Ejercicio2Form()
        {
            InitializeComponent();
        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            int Cantidad1 = int.Parse(Cantidad1TextBox.Text);
            int Cantidad2 = int.Parse(Cantidad2TextBox.Text);
            double Precio1 = Convert.ToDouble(Precio1TextBox.Text);
            double Precio2 = Convert.ToDouble(Precio2TextBox.Text);
            double total = await TotalAsync(Precio1, Precio2, Cantidad1, Cantidad2);
            MessageBox.Show("El total a pagar con descuento incluido es de: " + total);

        }
        private async Task<double> TotalAsync(double precio1, double precio2, int cantidad1, int cantidad2)
        {
            double total = await Task.Run(() =>
            {
                double totalsimple = (precio1 * cantidad1) + (precio2 * cantidad2);
                double totaldescuento = totalsimple * 0.15;
                return totalsimple - totaldescuento;
            });
            return total;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
