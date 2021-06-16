using MVVM.APP.Views.Bases;
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
using System.Windows.Shapes;

namespace MVVM.APP.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //register known windows via callback from ViewModelBase
            //when services are ready
            ViewModelBase.SetupVisualizer = (x) =>
            {
                x.Register("AddEditOrderPopup", typeof(AddEditOrderPopup));
            };

            this.DataContext = new MainWindowViewModel();
            InitializeComponent();
        }
    }
}
