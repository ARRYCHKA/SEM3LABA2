using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Microsoft.VisualBasic.Logging;
using Model;

namespace WinForms
{
    public partial class ChangeForm : Form
    {
        private readonly Car selectedCar;
        private readonly Logic _logic;
        public ChangeForm(Car car, Logic logic)
        {
            InitializeComponent();
            selectedCar = car;
            _logic = logic;
            selectedCar.Brand = newBrandText.Text;
            selectedCar.Color = newColorText.Text;
            selectedCar.Year = newYearText.Text;

        }
        /// <summary>
        /// Изменение автомобиля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newBrand = newBrandText.Text;
                string newColor = newColorText.Text;
                string newYear = newYearText.Text;

                _logic.UpdateCars(selectedCar.Id, newBrand, newColor, newYear);
                MessageBox.Show("Автомобиль успешно обновлён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
