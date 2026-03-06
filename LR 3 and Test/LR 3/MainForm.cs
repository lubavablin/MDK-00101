using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR_3
{
    public partial class MainForm : Form
    {
        private string[] parts = { "Корпус", "Вал", "Шестерня", "Крышка" };
        private string[,] materials =
        {
            { "Сталь листовая", "Алюминий", "Пластик" },
            { "Сталь круглая", "Нержавейка", "Металл" },
            { "Сталь закаленная", "Латунь", "Сталь" },
            { "Пластик", "Алюминий", "Оцинковка" }
        };

        private string[] materialDescriptions = {
            "Сталь листовая - 1500 руб/лист, Поставщик: МеталлПром, Группа: Металлопрокат",
            "Алюминий - 850 руб/кг, Поставщик: АлюминийТрейд, Группа: Металлопрокат",
            "Пластик - 300 руб/кг, Поставщик: ПластМаш, Группа: Полимеры",
            "Сталь круглая - 1200 руб/м, Поставщик: МеталлПром, Группа: Металлопрокат",
            "Нержавейка - 2500 руб/кг, Поставщик: СтальИнвест, Группа: Металлопрокат",
            "Сталь закаленная - 1800 руб/кг, Поставщик: МеталлПром, Группа: Металлопрокат",
            "Латунь - 2200 руб/кг, Поставщик: ЦветМет, Группа: Цветные металлы",
            "Оцинковка - 1400 руб/лист, Поставщик: МеталлПром, Группа: Металлопрокат"
        };

        private Image[] materialImages;

        private string orderText = "";

        public MainForm()
        {
            InitializeComponent();
            LoadImages();
            SetupForm();
        }

        private void LoadImages()
        {
            materialImages = new Image[8];
            Color[] colors = { Color.Gray, Color.Silver, Color.LightBlue,
                               Color.SteelBlue, Color.DarkGray, Color.LightSteelBlue,
                               Color.Gold, Color.SlateGray };

            for (int i = 0; i < 8; i++)
            {
                Bitmap jpg = new Bitmap(150, 150);
                using (Graphics g = Graphics.FromImage(jpg))
                {
                    g.Clear(colors[i]);
                    g.DrawString($"Материал {i + 1}",
                        new Font("Arial", 10, FontStyle.Bold),
                        Brushes.Black, 10, 60);
                }
                materialImages[i] = jpg;
            }
        }

        private void SetupForm()
        {
            listBoxParts.Items.AddRange(parts);

            toolTip1.SetToolTip(listBoxParts, "Выберите деталь для заказа");
            toolTip1.SetToolTip(comboBoxMaterials, "Выберите материал для детали");
            toolTip1.SetToolTip(numericUpDownQuantity, "Укажите количество");
            toolTip1.SetToolTip(btnAdd, "Добавить в заказ");
            toolTip1.SetToolTip(btnOrder, "Оформить заказ");
        }
        private void listBoxParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxParts.SelectedIndex >= 0)
            {
                comboBoxMaterials.Items.Clear();
                int partIndex = listBoxParts.SelectedIndex;
                for (int i = 0; i < materials.GetLength(1); i++)
                {
                    string material = materials[partIndex, i];
                    if (material != null)
                        comboBoxMaterials.Items.Add(material);
                }
                comboBoxMaterials.SelectedIndex = -1;
                pictureBoxMaterial.Image = null;
                lblDescription.Text = "Выберите материал";
            }
        }

        private void comboBoxMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMaterials.SelectedItem != null)
            {
                string materialName = comboBoxMaterials.SelectedItem.ToString();

                for (int i = 0; i < materialDescriptions.Length; i++)
                {
                    if (materialDescriptions[i].StartsWith(materialName))
                    {
                        lblDescription.Text = materialDescriptions[i];
                        pictureBoxMaterial.Image = materialImages[i];
                        break;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBoxParts.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите деталь!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxMaterials.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите материал!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Укажите количество больше 0!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string part = parts[listBoxParts.SelectedIndex];
            string material = comboBoxMaterials.SelectedItem.ToString();
            int quantity = (int)numericUpDownQuantity.Value;

            orderText += $"- {part}: {material} - {quantity} шт.\n";

            txtOrder.Text = orderText;

            numericUpDownQuantity.Value = 1;

            MessageBox.Show("Добавлено в заказ!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(orderText))
            {
                MessageBox.Show("Заказ пуст! Добавьте материалы.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullOrder = "ЗАКАЗ МАТЕРИАЛОВ\n\n";
            fullOrder += orderText;
            fullOrder += $"\nДата: {DateTime.Now:dd.MM.yyyy HH:mm}";

            MessageBox.Show(fullOrder, "Заказ оформлен",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            orderText = "";
            txtOrder.Text = "";
        }
    }
}
