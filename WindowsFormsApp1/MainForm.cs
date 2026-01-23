using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm: Form
    {
        List<Students> students = new List<Students>();
        public MainForm()
        {
            InitializeComponent();
            students.Add(new Students("Зенченко Любовь Сергеевна", 18, 5, 1));
            students.Add(new Students("Барсаков Крилл Алексеевич", 18, 2.21, 1));

            BoxStudents.DataSource = students;
            BoxStudents.DisplayMember = "name";
        }

        private void BoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Students s = (Students)BoxStudents.SelectedItem;
            name.Text = s.Name.ToString();
            age.Text = s.Age.ToString();
            numberBilet.Text = s.Number.ToString();
            avg.Text = s.Avg.ToString();

            
        }
    }
}
