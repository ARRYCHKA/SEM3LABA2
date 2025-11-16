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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms
{
    public partial class RemoveForm : Form
    {
        private readonly Logic _logic;
        public RemoveForm(Logic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        /// <summary>
        /// Вывод списка автомобилей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listButton_Click(object sender, EventArgs e)
        {
            List<List<string>> carsData = _logic.GetAllCars();
            string message = "";

            foreach (var car in carsData)
            {
                message += $" ID: {car[0]}, Марка: {car[1]}, Цвет: {car[2]}, Год: {car[3]}; \n";
            }

            if (string.IsNullOrEmpty(message))
            {
                message = "Нет автомобилей в списке.";
            }

            MessageBox.Show(message, "Список автомобилей");
        }
        
        private void exButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void delitButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idText.Text);
            _logic.RemoveCar (id);
        }

        
    }
}
