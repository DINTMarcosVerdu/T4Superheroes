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

namespace T4Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Superheroe> list;
        int listIndex;
        Superheroe currentHeroe;
        String numbers;
        public MainWindow()
        {
            list = Superheroe.GetSamples();
            InitializeComponent();
            numbers = listIndex + 1 + "/" + list.Count();
            currentSlideIndicatortextBlock.Text = numbers;
            listIndex = 0;
            mainDockPanel.DataContext = list[listIndex];
        }

        private void antras_MouseDown(object sender, MouseButtonEventArgs e)
        {
            manageList(-1);
        }

        private void siguiente_MouseDown(object sender, MouseButtonEventArgs e)
        {
            manageList(1);
        }

        private void manageList(int op)
        {
            int tamañoLista = list.Count();
            int i = listIndex;
            i += op;

            if (i < 0)
                i = 0;
            else if (i > list.Count() - 1)
                i = list.Count() - 1;

            listIndex = i;
            mainDockPanel.DataContext = list[listIndex];
            numbers = listIndex + 1 + "/" + list.Count();
            currentSlideIndicatortextBlock.Text = numbers;

        }
    }
}
