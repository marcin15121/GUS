using GUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUS.Views
{
    public partial class AreasView : UserControl
    {
        public AreasView()
        {
            InitializeComponent();
            DataContext = new AreasViewModel();
            LoadData();
        }
        private async void LoadData()
        {
            var viewModel = DataContext as AreasViewModel;
            await viewModel.LoadAreasAsync();
        }
    }
}
