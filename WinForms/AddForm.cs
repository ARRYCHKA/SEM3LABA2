using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Model;

namespace WinForms
{
    public partial class AddForm : Form
    {
        private readonly Logic _logic;
        public AddForm(Logic logic)
        {
            InitializeComponent();
            _logic =logic;
            
        }
        /// <summary>
        /// Добавление автомобиля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                int id = Convert.ToInt32(idTextBox.Text);
                string brand = brandTextBox.Text.Trim();
                string color = colorTextBox.Text.Trim();
                string year = yearTextBox.Text.Trim();
                
                _logic.AddCars(id,  brand, color, year);
                MessageBox.Show("Автомобиль добавлен!");
                ClearFields();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("ID введен не правильно!");
            }
        }
        
        private void ClearFields()
        {
            idTextBox.Clear();
            brandTextBox.Clear();
            colorTextBox.Clear();
            yearTextBox.Clear();
        }
        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
