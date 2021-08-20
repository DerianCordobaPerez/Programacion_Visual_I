using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Practica_01
{
    public partial class Form1 : Form
    {

        private Car car = null;
        private List<string> Propertys = new List<string>() { "Rine", "Transmission", "Status", "Brand", "Price", "Mileage" };
        private List<string> PropertiesSpanish = new List<string>() { "Rines", "Trasmision", "Estado", "Marca", "Precio", "Kilometro" };

        public Form1()
        {
            InitializeComponent();
        }

        private IEnumerable<Control> GetControls(string key) 
            => Controls
                .OfType<Control>()
                .Where(control => control.Name.StartsWith(key))
                .Select(control => control);

        private bool ValidateFields(IEnumerable<Control> controls) 
            => controls.All(control => !string.IsNullOrEmpty(control.Text));

        private void ResetFields(IEnumerable<Control> controls)
        {
            foreach (Control control in controls)
                control.Text = string.Empty;
        }

        private Car NewCar(List<string> values)
        {
            Car car = new Car();

            for (int i = 0; i < values.Count; ++i)
            {
                if (Propertys.ElementAt(i).CompareTo("Price") == 0 || Propertys.ElementAt(i).CompareTo("Mileage") == 0)
                    car.GetType().GetProperty(Propertys.ElementAt(i))
                        .SetValue(car, Convert.ToDouble(values[i]));
                else
                    car.GetType().GetProperty(Propertys.ElementAt(i))
                        .SetValue(car, values[i]);
            }

            return car;
        }

        private void SaveData(IEnumerable<Control> controls)
        {
            if (ValidateFields(controls))
            {
                MessageBox.Show("Datos guardados correctamente", "Exito al guardar");
                car = NewCar(controls.Select(control => control.Text.Trim()).ToList());
                ResetFields(controls);
            }
            else
                MessageBox.Show("Error al guardar los datos", "Ocurrio Error");
        }

        private void AllowOnlyNumberTextBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void MoveCursorAndValidateTextBox(TextBox textBox)
        {
            if (textBox.Text.StartsWith("."))
                textBox.Text = $"0{textBox.Text}";
        }

        private void buttonShowCars_Click(object sender, EventArgs e)
        {
            if (car != null)
            {
                string content = "AUTO REGISTRADO\n";
                for (int i = 0; i < Propertys.Count; ++i)
                    content += $"{PropertiesSpanish.ElementAt(i)}: {car.GetType().GetProperty(Propertys.ElementAt(i)).GetValue(car, null)}\n";

                MessageBox.Show($"{content}");
            }
            else
                MessageBox.Show("No se ha ingresado ningun auto");
        }

        private void buttonSaveCar_Click(object sender, EventArgs e)
        {
            SaveData(GetControls("Control"));
        }

        private void ControlTextBoxMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumberTextBox(sender, e);
        }

        private void ControlTextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {    
            AllowOnlyNumberTextBox(sender, e);
        }

        private void ControlTextBoxMileage_Leave(object sender, EventArgs e)
        {
            MoveCursorAndValidateTextBox(ControlTextBoxMileage);
        }

        private void ControlTextBoxPrice_Leave(object sender, EventArgs e)
        {
            MoveCursorAndValidateTextBox(ControlTextBoxPrice);
        }
    }
}
