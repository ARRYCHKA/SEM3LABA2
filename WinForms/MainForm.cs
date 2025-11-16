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

namespace WinForms
{
    public partial class MainForm : Form
    {
        private readonly Logic _logic;
        

        public MainForm()
        {
            InitializeComponent();
            _logic= new Logic();
        }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(_logic);
            addForm.ShowDialog();

        }
        

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveForm removeForm =new RemoveForm(_logic);
            removeForm.ShowDialog();
            
        }
        /// <summary>
        /// Форма для чтения ( выводит сообщение со списком автомобилей)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readButton_Click(object sender, EventArgs e)
        {
            List<List<string>> carsData = _logic.GetAllCars();
            string message = "";

            foreach (var car in carsData)
            {
                message += $"ID: {car[0]}, Марка: {car[1]}, Цвет: {car[2]}, Год: {car[3]}; \n";
            }

            if (string.IsNullOrEmpty(message))
            {
                message = "Нет автомобилей в списке.";
            }

            MessageBox.Show(message, "Список автомобилей");
        }           
                
        
        private void updateButton_Click(object sender, EventArgs e)
        {
            UpDateForm upDateForm = new UpDateForm(_logic);
            upDateForm.ShowDialog();
        }
        

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorForm colorForm = new ColorForm(_logic);
            colorForm.ShowDialog();
        }
        

        private void yaerButton_Click(object sender, EventArgs e)
        {
            YearForm yearForm = new YearForm(_logic);
            yearForm.ShowDialog();
        }
    }
}
