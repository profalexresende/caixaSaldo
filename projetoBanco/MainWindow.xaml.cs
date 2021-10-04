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

namespace projetoBanco
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

        double saldo = 0;

        private void btnProcessar_Click(object sender, RoutedEventArgs e)
        {
            double valor;
            int codTransacao;

            valor = Convert.ToDouble(txtValor.Text);
            codTransacao = Convert.ToInt32(txtCodigoTransacao.Text);

            switch (codTransacao)
            {
                case 1: //Depósito
                    saldo = saldo + valor;
                    MessageBox.Show("Depósito efetuado!", "Depósito",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    break;
                case 2://SAQUE
                    saldo = saldo - valor;
                    MessageBox.Show("Saque efetuado!", "Saque",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    break;
                case 3:
                    MessageBox.Show("Saldo Atual: R$" + saldo.ToString("0.00"), "Saldo",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    break;
                default:
                    MessageBox.Show("Código Inválido ", "Atenção",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }

        }
    }
}
