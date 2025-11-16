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
using Model;

namespace WinForms
{
    public partial class YearForm : Form
    {
        private readonly Logic _logic;
        public YearForm(Logic logic)
        {
            InitializeComponent();
            _logic=logic;
        }
        /// <summary>
        /// Поиск автомобиля по году
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string year = yearTextBox.Text.Trim();
            List<Car> foundCars = _logic.FindCarByYear(year);

            if (foundCars.Count == 0)
            {
                MessageBox.Show("Автомобили с таким годом не найдены.");
            }
            else
            {
                DisplayCars(foundCars);
            }
        }
        private void DisplayCars(List<Car> cars)
        {
            CarList.Items.Clear();
            foreach (var car in cars)
            {                
                CarList.Items.Add($"ID: {car.Id}, Марка: {car.Brand}, Цвет: {car.Color}, Год: {car.Year}");
            }
        }
      
        private void exButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
