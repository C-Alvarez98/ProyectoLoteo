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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        TablaCuentaCorriente sql = new TablaCuentaCorriente();

        private void DGVctaCorriente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVctaCorriente.Rows[e.RowIndex];
            TxtIdCuenta.Text = Convert.ToString(fila.Cells[0].Value);
            TxtIdlote.Text = Convert.ToString(fila.Cells[1].Value);
            TxtIdcomprador.Text = Convert.ToString(fila.Cells[2].Value);
            TxtFechaPago.Text = Convert.ToString(fila.Cells[3].Value);
            TxtCuotaPagada.Text= Convert.ToString(fila.Cells[4].Value);
            TxtMonto.Text = Convert.ToString(fila.Cells[5].Value);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DGVctaCorriente.DataSource = sql.MostrarDatos();
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            TxtIdCuenta.Text = DGVctaCorriente.Rows.Count.ToString();
            if (sql.Insertar(TxtIdCuenta.Text,TxtIdlote.Text,TxtIdcomprador.Text,TxtFechaPago.Text,TxtCuotaPagada.Text,TxtMonto.Text ))
            {
                MessageBox.Show("Datos insertados");
                DGVctaCorriente.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido insertar los datos");

            TxtIdCuenta.Clear();
            TxtIdlote.Clear();
            TxtIdcomprador.Clear();
            TxtFechaPago.Clear();
            TxtCuotaPagada.Clear();
            TxtMonto.Clear();
            TxtIdlote.Focus();
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (sql.Eliminar(TxtIdCuenta.Text))
            {
                MessageBox.Show("Datos eliminados");
                DGVctaCorriente.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
            TxtIdCuenta.Clear();
            TxtIdlote.Clear();
            TxtIdcomprador.Clear();
            TxtFechaPago.Clear();
            TxtCuotaPagada.Clear();
            TxtMonto.Clear();
            TxtIdlote.Focus();
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            
            if (sql.Actualizar(TxtIdCuenta.Text, TxtIdlote.Text, TxtIdcomprador.Text, TxtFechaPago.Text, TxtCuotaPagada.Text, TxtMonto.Text))
            {
                MessageBox.Show("Datos actualizados");
                DGVctaCorriente.DataSource = sql.MostrarDatos();
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
                if (CBbuscar.SelectedIndex == 0)
                    DGVctaCorriente.DataSource = sql.BuscarIdCuenta(TxtBuscar.Text);
                else if (CBbuscar.SelectedIndex == 1)
                    DGVctaCorriente.DataSource = sql.BuscarIdLote(TxtBuscar.Text);
                else if (CBbuscar.SelectedIndex == 2)
                    DGVctaCorriente.DataSource = sql.BuscarIdComprador(TxtBuscar.Text);
                else if (CBbuscar.SelectedIndex == 3)
                    DGVctaCorriente.DataSource = sql.BuscarFechaPago(TxtBuscar.Text);
                else if (CBbuscar.SelectedIndex == 4)
                    DGVctaCorriente.DataSource = sql.BuscarCuotaPagada(TxtBuscar.Text);
                else if (CBbuscar.SelectedIndex == 5)
                    DGVctaCorriente.DataSource = sql.BuscarMonto(TxtBuscar.Text);
            }
            else DGVctaCorriente.DataSource = sql.MostrarDatos();

        }

        private void CBbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBbuscar.SelectedIndex == 0 || CBbuscar.SelectedIndex == 1 || CBbuscar.SelectedIndex == 2 || CBbuscar.SelectedIndex == 3 || CBbuscar.SelectedIndex == 4 || CBbuscar.SelectedIndex == 5)
                TxtBuscar.Focus();
        }

    }
}
