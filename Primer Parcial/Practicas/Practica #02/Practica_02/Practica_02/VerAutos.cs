using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

namespace Practica_02
{
    public partial class VerAutos : Form
    {
        public List<Auto> autos { get; set; }

        public VerAutos()
        {
            InitializeComponent();
        }

        public VerAutos(List<Auto> _autos)
        {
            InitializeComponent();
            autos = _autos;
            MostrarDatos(autos);
            ComboBoxBuscar.SelectedIndex = 0;
            ButtonEliminar.Enabled = autos.Count > 0;
        }

        private void MostrarDatos(List<Auto> autos) 
            => DataGridViewAutos.DataSource = new BindingSource(new BindingList<Auto>(autos), null);

        private void BuscarAutosPorMarca()
        {
            var _autos = string.Compare("Todos", ComboBoxBuscar.Text, StringComparison.Ordinal) == 0
                ? autos
                : autos
                    .Select(auto => auto)
                    .Where(auto => string.Compare(auto.Marca.ToLower().Trim(), ComboBoxBuscar.Text.ToLower().Trim(), StringComparison.OrdinalIgnoreCase) == 0)
                    .ToList();

            MostrarDatos(_autos);
        }

        private void ComboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonEliminar.Text = string.Compare(ComboBoxBuscar.Text, "Todos", StringComparison.OrdinalIgnoreCase) != 0 ? 
                    "Eliminar todos" : "Eliminar";

            BuscarAutosPorMarca();
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (string.Compare(ComboBoxBuscar.Text, "Todos", StringComparison.OrdinalIgnoreCase) != 0)
                EliminarTodosAutosPorMarca();
            else
                EliminarAuto();
            
            ButtonEliminar.Enabled = autos.Count > 0;
            BuscarAutosPorMarca();
        }

        private void EliminarTodosAutosPorMarca()
        {
            var _autos = autos.Select(auto => auto).Where(auto => auto.Marca == ComboBoxBuscar.Text).ToList();
            if (_autos.Count > 0)
                foreach (var auto in _autos)
                    autos.Remove(auto);
        }

        private void EliminarAuto()
        {
            if (DataGridViewAutos.Rows.Count > 0)
            {
                if (DataGridViewAutos.CurrentRow != null && DataGridViewAutos.CurrentRow.Index != -1)
                    autos.RemoveAt(DataGridViewAutos.CurrentRow.Index);
            }
        }
    }
}
