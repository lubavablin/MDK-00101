using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using SalesLibrary;
using SalesLibrary.Analysis;
using SalesLibrary.Presenters;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Media;

namespace ChartTest
{
    public partial class MainForm : Form
    {
        private SalesPresenter presenter_;
        void FillCartesianChart()
        {
            ItemsList.DataSource = presenter_.GetAllItems();
            ItemsList.DisplayMember = "Name";
            if (ItemsList.Items.Count > 0)
            {
                presenter_.ShowSalesByItem(((Item)ItemsList.Items[0]).Name);
            }
        }

        void FillAngular()
        {
            angular.FromValue = 40;
            angular.ToValue = 100;

            angular.TicksForeground = Brushes.HotPink;
            angular.NeedleFill = Brushes.Black;
        }

        void FillSolid()
        {
            solid.From = 60;
            solid.To = 100;
            solid.LabelFormatter = value => value + "%";
        }
        public MainForm()
        {
            InitializeComponent();

            presenter_ = new SalesPresenter(new List<ISalesView> { cartesian });

            FillCartesianChart();

            FillAngular();

            FillSolid();


            FillPieChart();

        }

        private void ItemsList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Item selectedItem = ((Item)(ItemsList.SelectedItem));
            if(selectedItem == null)
            {
                return;
            }

            presenter_.ShowSalesByItem(selectedItem.Name);
            double percent = Math.Round(
                presenter_.GetProfitPercentByItem(selectedItem), 2);

            angular.Value = percent;
            solid.Value = percent;
        }

        private void angular_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void cartesian_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
        void FillPieChart()
        {
            pieChart1.Series = new SeriesCollection
    {
        new PieSeries
        {
            Title ="Мальчиков",
            Values = new ChartValues<double>{40},
        },
        new PieSeries
        {
            Title ="Девочек",
            Values = new ChartValues<double>{60},
        }

    };
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
}
