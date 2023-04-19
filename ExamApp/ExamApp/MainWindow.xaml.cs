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

namespace ExamApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            tblAuthorMessage.Visibility = Visibility.Hidden;
            tblNameMessage.Visibility = Visibility.Hidden;
            tblYearMessage.Visibility = Visibility.Hidden;
        }

        private void tbAuthor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Validator.ValidateAuthor(tbAuthor.Text))
                tblAuthorMessage.Visibility = Visibility.Hidden;
            else
                tblAuthorMessage.Visibility = Visibility.Visible;
        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Validator.ValidateName(tbName.Text))
                tblNameMessage.Visibility = Visibility.Hidden;
            else
                tblNameMessage.Visibility = Visibility.Visible;
        }

        private void tbYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Validator.ValidateYear(tbYear.Text))
                tblYearMessage.Visibility = Visibility.Hidden;
            else
                tblYearMessage.Visibility = Visibility.Visible;
        }
    }
}
