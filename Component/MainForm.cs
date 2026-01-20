using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component
{
    public partial class MainForm: Form
    {
        int RandomNum;
        public MainForm()
        {
            InitializeComponent();
            Random rnd = new Random();
         RandomNum = rnd.Next(1, 101);
            
        }
       
       

        private void Proverka_Click(object sender, EventArgs e)
        {
        int number = Convert.ToInt32(Number.Text);
            if (number > RandomNum) 
            {
                MessageBox.Show("Загаданное число меньше");
            }
            if (number < RandomNum) 
            {
                MessageBox.Show("Загаданное число больше");
            }
            if (number == RandomNum) 
            {
                MessageBox.Show("Ты молодец!!! Угодал!!!");
            }
        }

       
    }
}
