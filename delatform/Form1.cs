using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delatform
{
    public partial class MineForm: Form
    {
        public MineForm()
        {
            InitializeComponent();
            FileNameListBox.Items.Add("in");
            FileNameListBox.Items.Add("is");
            FileNameListBox.Items.Add("were");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = FileNameListBox.SelectedIndex;
            MessageBox.Show(Convert.ToString(index));
        }

        private void Load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                var fileComtent = string.Empty;
                var filePatisc = string.Empty;

                openFileDialog.InitialDirectory = "c\\";
                openFileDialog.Filter = "image files (*.JPG)*.JPG|image files (*.PNG)*.PNG|image files (*.BMP)*.BMP|";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePatisc = openFileDialog.FileName;
                    FileNameListBox.Items.Add(filePatisc);
                }

            }
        }
    }
}
