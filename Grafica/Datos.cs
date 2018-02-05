using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Grafica
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void Datos_Load( object sender, EventArgs e )
        {
            comBxLinea.Items.Add( "1" );
            comBxLinea.SelectedIndex = 0;
            comBxTipo.SelectedIndex = 0;
            var serie = chartPuntos.Series.Add( comBxLinea.Items.Count.ToString() );
            var tipo = comBxTipo.SelectedItem.ToString();
            serie.ChartType = (SeriesChartType)Enum.Parse( typeof( SeriesChartType ), tipo );
        }

        private void btnLimpiar_Click( object sender, EventArgs e )
        {
            chartPuntos.Series.Clear();
            comBxLinea.Items.Clear();
            comBxLinea.Items.Add( "1" );
            comBxLinea.SelectedIndex = 0;
            var serie = chartPuntos.Series.Add( comBxLinea.Items.Count.ToString() );
            var tipo = comBxTipo.SelectedItem.ToString();
            serie.ChartType = (SeriesChartType)Enum.Parse( typeof( SeriesChartType ), tipo );
        }

        private void btnAgregarL_Click( object sender, EventArgs e )
        {
            comBxLinea.Items.Add( comBxLinea.Items.Count + 1 );
            var serie = chartPuntos.Series.Add( comBxLinea.Items.Count.ToString() );
            var tipo = comBxTipo.SelectedItem.ToString();
            serie.ChartType = (SeriesChartType)Enum.Parse( typeof( SeriesChartType ), tipo );
            MessageBox.Show( "Linea Agregada", "Linea", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void btnEliminar_Click( object sender, EventArgs e )
        {
            if (comBxLinea.Items.Count > 1)
            {
                chartPuntos.Series.RemoveAt( chartPuntos.Series.IndexOf( comBxLinea.SelectedItem.ToString() ) );
                comBxLinea.Items.RemoveAt( comBxLinea.SelectedIndex );
                comBxLinea.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show( "No se puede quedar sin lineas", "Linea", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void btnAgregarP_Click( object sender, EventArgs e )
        {
            var serie = chartPuntos.Series.ElementAt( chartPuntos.Series.IndexOf( comBxLinea.SelectedItem.ToString() ) );
            serie.Points.AddXY( Convert.ToDouble( txtBxX.Text ), Convert.ToDouble( txtBxY.Text ) );
            MessageBox.Show( "Punto Agregado", "Punto", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void txtBxX_KeyPress( object sender, KeyPressEventArgs e )
        {
            Validaciones.Numeros( e, txtBxX, true, true );
        }

        private void txtBxY_KeyPress( object sender, KeyPressEventArgs e )
        {
            Validaciones.Numeros( e, txtBxY, true, true );
        }
    }
}
