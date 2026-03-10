using LiveCharts;
using LiveCharts.Wpf;
using SalesLibrary;
using SalesLibrary.Analysis;
using SalesLibrary.Models;
using SalesLibrary.Presenters;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChartTest.Views
{
    class SalesPieChart : LiveCharts.WinForms.PieChart, ISalesView
    {
        private SalesModel model_;
        private SectionsCollection series_;
        private SalesPresenter presenter_;

        public void SetPresenter (SalesPresenter presenter)
        {
            presenter_ = presenter;
        }
        public void Show(List<Sale> sales)
        {
            List<Item> salles = presenter_.GetAllItems();
            SeriesCollection seriesViews = new SeriesCollection();
            foreach (var item in salles)
            {
                seriesViews.Add(new PieSeries
                {
                    Title = item.Name,
                    Values = new ChartValues<double>() { presenter_.GetProfitPercentByItem(item) }
                });
            }
            Series = seriesViews;
        }
    }
}
