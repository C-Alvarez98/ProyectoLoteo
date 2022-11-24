using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Casasola
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        TablaSocios sql = new TablaSocios();
        private void DGVsocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVsocios.Rows[e.RowIndex];
            txtIdSocios.Text = Convert.ToString(fila.Cells[0].Value);
            TxtApeyNomSocio.Text = Convert.ToString(fila.Cells[1].Value);
            TxtDniSocio.Text = Convert.ToString(fila.Cells[2].Value);
            TxtDomicilioSocio.Text = Convert.ToString(fila.Cells[3].Value);
            TxtTelSocio.Text = Convert.ToString(fila.Cells[4].Value);
            TxtCantLotes.Text = Convert.ToString(fila.Cells[5].Value);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DGVsocios.DataSource = sql.MostrarDatos();
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            txtIdSocios.Text = DGVsocios.Rows.Count.ToString();
            if (sql.Insertar(txtIdSocios.Text, TxtApeyNomSocio.Text, TxtDniSocio.Text, TxtDomicilioSocio.Text, TxtTelSocio.Text, TxtCantLotes.Text))
            {
                MessageBox.Show("Datos insertados");
               
            }
            else 
                TxtDniSocio.Text = "12341254";
                MessageBox.Show("No se han podido insertar los datos");
            //DGVsocios.DataSource = sql.MostrarDatos();

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (sql.Eliminar(txtIdSocios.Text))
            {
                MessageBox.Show("Datos eliminados");
                DGVsocios.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
            txtIdSocios.Clear();
            TxtApeyNomSocio.Clear();
            TxtDniSocio.Clear();
            TxtDomicilioSocio.Clear();
            TxtTelSocio.Clear();
            TxtCantLotes.Clear();
            TxtApeyNomSocio.Focus();

        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            
            if (sql.Actualizar(txtIdSocios.Text, TxtApeyNomSocio.Text, TxtDniSocio.Text, TxtDomicilioSocio.Text, TxtTelSocio.Text, TxtCantLotes.Text))
            {
                MessageBox.Show("Datos actualizados");
                DGVsocios.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido actualizar los datos");
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text != "")
            {
                if (CBBuscar.SelectedIndex == 0)
                    DGVsocios.DataSource = sql.BuscarIdSocio(TxtBuscar.Text);
                else if (CBBuscar.SelectedIndex == 1)
                    DGVsocios.DataSource = sql.BuscarApeyNomb(TxtBuscar.Text);
                else if (CBBuscar.SelectedIndex == 2)
                    DGVsocios.DataSource = sql.BuscarDNI(TxtBuscar.Text);
                else if (CBBuscar.SelectedIndex == 3)
                    DGVsocios.DataSource = sql.BuscarDomicilio(TxtBuscar.Text);
                else if (CBBuscar.SelectedIndex == 4)
                    DGVsocios.DataSource = sql.BuscarTelefono(TxtBuscar.Text);
                else if (CBBuscar.SelectedIndex == 5)
                    DGVsocios.DataSource = sql.BuscarCantidadlotes(TxtBuscar.Text);
            }
            else DGVsocios.DataSource = sql.MostrarDatos();

        }

        private void CBBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBuscar.SelectedIndex == 0 || CBBuscar.SelectedIndex == 1 || CBBuscar.SelectedIndex == 2 || CBBuscar.SelectedIndex == 3 || CBBuscar.SelectedIndex == 4 || CBBuscar.SelectedIndex == 5)
                TxtBuscar.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
