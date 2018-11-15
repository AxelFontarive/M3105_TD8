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

namespace GitLab_Test
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Ceci est un commentaire ajoué depuis GitHub !
            InitializeComponent();
        }

        private void Button_Valider_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("click sur le bouton valider");
        }
    }
}
