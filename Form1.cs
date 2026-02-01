using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio31
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void grpEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
         "¿Desea salir de la aplicación?",
         "Confirmar salida",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de texto (*.txt)|*.txt";
            abrir.Title = "Abrir archivo de empleados";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("notepad.exe", abrir.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivos de texto (*.txt)|*.txt";
            guardar.Title = "Guardar archivo de empleados";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(guardar.FileName))
                {
                    sw.WriteLine("===== REGISTRO DE EMPLEADO =====");
                    sw.WriteLine("----------------------------------------------");
                    sw.WriteLine($"ID:\t\t{txtlD.Text}");
                    sw.WriteLine($"Nombre:\t\t{txtNombre.Text}");
                    sw.WriteLine($"Apellidos:\t{txtApellidos.Text}");
                    sw.WriteLine($"Dirección:\t{txtDirrecion.Text}");
                    sw.WriteLine($"Teléfono:\t{txtTeléfono.Text}");
                    sw.WriteLine($"Email:\t\t{txtEmail.Text}");
                    sw.WriteLine($"Cargo:\t\t{txtCargo.Text}");
                    sw.WriteLine($"Salario:\t{txtTeléfono.Text}");
                    sw.WriteLine($"Fecha Ingreso:\t{dtokIngreso.Value.ToShortDateString()}");
                    sw.WriteLine($"Género:\t\t{cmbGenero.Text}");
                }

                MessageBox.Show("Archivo guardado correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
  private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtlD.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtDirrecion.Text) ||
                string.IsNullOrWhiteSpace(txtTeléfono.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtSalarrio.Text) ||
                cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos deben estar completos.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtlD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtlD.Clear();
            txtNombre.Clear();
            txtDirrecion.Clear();
            txtTeléfono.Clear();
            txtEmail.Clear();
            txtCargo.Clear();
            txtApellidos.Clear();
            txtSalarrio.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
