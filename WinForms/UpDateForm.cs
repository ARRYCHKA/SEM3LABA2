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
    public partial class UpDateForm : Form
    {
        private readonly Logic _logic;
        public UpDateForm(Logic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        

        private void exbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 
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
        /// <summary>
        /// Открытие формы для изменения автомобиля, найденного по id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idtextBox.Text);
                var car = _logic.FindCarByID(id);

                if (car != null)
                {
                    ChangeForm changeForm = new ChangeForm(car, _logic);
                    changeForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Автомобиля с таким ID не найдено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный формат ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
    }
}
