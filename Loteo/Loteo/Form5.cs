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
    public partial class z : Form
    {
        public z()
        {
            InitializeComponent();
        }
        TablaLotes sql = new TablaLotes();
        private void DGVlotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVlotes.Rows[e.RowIndex];
            TxtIdlotes.Text = Convert.ToString(fila.Cells[0].Value);
            TxtCategoria.Text = Convert.ToString(fila.Cells[1].Value);
            Txtdimension.Text = Convert.ToString(fila.Cells[2].Value);
            TxtAsignado.Text = Convert.ToString(fila.Cells[3].Value);
            TxtPrecio.Text = Convert.ToString(fila.Cells[4].Value);
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DGVlotes.DataSource = sql.MostrarDatos();
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            TxtIdlotes.Text = DGVlotes.Rows.Count.ToString();
            if (sql.Insertar(TxtIdlotes.Text,TxtCategoria.Text,Txtdimension.Text,TxtAsignado.Text,TxtPrecio.Text))
            {
                MessageBox.Show("Datos insertados");
                DGVlotes.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido insertar los datos");

            TxtIdlotes.Clear();
            TxtCategoria.Clear();
            Txtdimension.Clear();
            TxtAsignado.Clear();
            TxtPrecio.Clear();
            TxtCategoria.Focus();

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {

            if (sql.Eliminar(TxtIdlotes.Text))
            {
                MessageBox.Show("Datos eliminados");
                DGVlotes.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
            TxtIdlotes.Clear();
            TxtCategoria.Clear();
            Txtdimension.Clear();
            TxtAsignado.Clear();
            TxtPrecio.Clear();
            TxtCategoria.Focus();
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            if (sql.Actualizar(TxtIdlotes.Text, TxtCategoria.Text, Txtdimension.Text, TxtAsignado.Text, TxtPrecio.Text))
            {
                MessageBox.Show("Datos actualizados");
                DGVlotes.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido actualizar los datos");
        }

        private void Btvolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (Txtbuscar.Text != "")
            {
                if (CBBuscar.SelectedIndex == 0)
                    DGVlotes.DataSource = sql.BuscarIdLotes(Txtbuscar.Text);
                else if (CBBuscar.SelectedIndex == 1)
                    DGVlotes.DataSource = sql.BuscarCategoria(Txtbuscar.Text);
                else if (CBBuscar.SelectedIndex == 2)
                    DGVlotes.DataSource = sql.BuscarDimension(Txtbuscar.Text);
                else if (CBBuscar.SelectedIndex == 3)
                    DGVlotes.DataSource = sql.BuscarAsignado(Txtbuscar.Text);
                else if (CBBuscar.SelectedIndex == 4)
                    DGVlotes.DataSource = sql.BuscarPrecioxMetro(Txtbuscar.Text);
            }
            else DGVlotes.DataSource = sql.MostrarDatos();
        }

        private void CBBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBuscar.SelectedIndex == 0 || CBBuscar.SelectedIndex == 1 || CBBuscar.SelectedIndex == 2 || CBBuscar.SelectedIndex == 3 || CBBuscar.SelectedIndex == 4)
                Txtbuscar.Focus();
        }
    }
}
