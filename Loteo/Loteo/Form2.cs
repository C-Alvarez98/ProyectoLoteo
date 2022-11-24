using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Casasola
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        TablaCompradores sql = new TablaCompradores();

        private void DGVcompradore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVcompradores.Rows[e.RowIndex];
            TxtIdComprador.Text = Convert.ToString(fila.Cells[0].Value);
            TxtApeNombComp.Text = Convert.ToString(fila.Cells[1].Value);
            TxtDNIcomp.Text = Convert.ToString(fila.Cells[2].Value);
            TxtDomicilioComp.Text = Convert.ToString(fila.Cells[3].Value);
            TxtTelcomp.Text = Convert.ToString(fila.Cells[4].Value);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DGVcompradores.DataSource = sql.MostrarDatos();

        }

        private void BtGuardarComp_Click(object sender, EventArgs e)
        {
            TxtIdComprador.Text = DGVcompradores.Rows.Count.ToString();
            if (sql.Insertar(TxtIdComprador.Text, TxtApeNombComp.Text, TxtDNIcomp.Text, TxtDomicilioComp.Text, TxtTelcomp.Text))
            {
                MessageBox.Show("Datos insertados");
                DGVcompradores.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido insertar los datos");
            TxtApeNombComp.Clear();
            TxtDNIcomp.Clear();
            TxtDomicilioComp.Clear();
            TxtTelcomp.Clear();
            TxtIdComprador.Clear();
            TxtApeNombComp.Focus();

        }

        private void BtEliminarComp_Click(object sender, EventArgs e)
        {
            if (sql.Eliminar(TxtIdComprador.Text))
            {
                MessageBox.Show("Datos eliminados");
                DGVcompradores.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
            TxtApeNombComp.Clear();
            TxtDNIcomp.Clear();
            TxtDomicilioComp.Clear();
            TxtTelcomp.Clear();
            TxtIdComprador.Clear();
            TxtApeNombComp.Focus();
        }

        private void BtmodificarComp_Click(object sender, EventArgs e)
        {
            if (sql.Actualizar(TxtIdComprador.Text, TxtApeNombComp.Text, TxtDNIcomp.Text, TxtDomicilioComp.Text, TxtTelcomp.Text))
            {
                MessageBox.Show("Datos modificados");
                DGVcompradores.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido modificar los datos");
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
                    DGVcompradores.DataSource = sql.BuscarIdCompradores(TxtBuscar.Text);
                else if (CBbuscar.SelectedIndex == 1)
                    DGVcompradores.DataSource = sql.Buscar(TxtBuscar.Text);
                else if (CBbuscar.SelectedIndex == 2)
                    DGVcompradores.DataSource = sql.BuscarDNI(TxtBuscar.Text);
                else if (CBbuscar.SelectedIndex == 3)
                    DGVcompradores.DataSource = sql.BuscarDomicilio(TxtBuscar.Text);
                else if (CBbuscar.SelectedIndex == 4)
                     DGVcompradores.DataSource = sql.BuscarTelefono(TxtBuscar.Text);
            }
            else DGVcompradores.DataSource = sql.MostrarDatos();
        }

        private void CBbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBbuscar.SelectedIndex == 0 || CBbuscar.SelectedIndex == 1 || CBbuscar.SelectedIndex == 2 || CBbuscar.SelectedIndex == 3 || CBbuscar.SelectedIndex == 4)
                TxtBuscar.Focus();
        } 

       
     }
}

