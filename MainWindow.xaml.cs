using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ControleClientes.Core.Collections;

namespace ControleClientes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EnderecoCollection enderecos = new EnderecoCollection();
            McDataGrid.ItemsSource = enderecos.LoadEndereco();
        }
    }
}
