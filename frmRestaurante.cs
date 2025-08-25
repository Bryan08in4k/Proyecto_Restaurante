using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_Restaurante
{
    public partial class frmRestaurante : Form
    {
        public frmRestaurante()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Pollo Frito", 20, cantidad * 20);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Hamburgesas", 25, cantidad * 25);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad:"));
            dataGridView1.Rows.Add(cantidad, "Menú", 40, cantidad * 40);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Ensaladas", 35, cantidad * 35);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Bebidas", 20, cantidad * 20);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Postres", 20, cantidad * 20);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Antojitos", 25, cantidad * 25);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Conbo Familiar", 70, cantidad * 70);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int suma = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                suma += (int)fila.Cells[3].Value;
            }
            txtTotal.Text = suma.ToString();
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {

        }
    }
    
    
    
}
