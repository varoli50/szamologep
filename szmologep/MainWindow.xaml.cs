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

namespace szmologep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Novel1.Click += Novel1_Click;
            Novel2.Click += Novel2_Click;
            Csokken1.Click += Csokken1_Click;
            Csokken2.Click += Csokken2_Click;
            osszeadas.Click += Osszeadas_Click;
            kivonas.Click += Kivonas_Click;
            szorozas.Click += Szorozas_Click;
            osztas.Click += Osztas_Click;
        }

        private void Osztas_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Szorozas_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Kivonas_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Osszeadas_Click(object sender, RoutedEventArgs e)
        {
            int vegeredmeny = Convert.ToInt32(eredmeny.Text);
            int osszead = vegeredmeny(szam1+szam2);
            eredmeny.Text
        }

        private void Csokken2_Click(object sender, RoutedEventArgs e)
        {
            int jelenlegi = Convert.ToInt32(szam2.Text);
            int csokken = jelenlegi - 1;
            szam2.Text = csokken.ToString();
        }

        private void Csokken1_Click(object sender, RoutedEventArgs e)
        {
            int jelenlegi = Convert.ToInt32(szam1.Text);
            int csokken = jelenlegi - 1;
            szam1.Text = csokken.ToString();
        }

        private void Novel2_Click(object sender, RoutedEventArgs e)
        {
            int jelenlegi = Convert.ToInt32(szam2.Text);
            int novel = jelenlegi + 1;
            szam2.Text = novel.ToString();
        }

        private void Novel1_Click(object sender, RoutedEventArgs e)
        {
            int jelenlegi = Convert.ToInt32(szam1.Text);
            int novel = jelenlegi + 1;
            szam1.Text = novel.ToString(); 
        }
    }
}
