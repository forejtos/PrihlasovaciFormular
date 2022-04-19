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
using System.Text.RegularExpressions;

namespace PrihlasovaciFormular
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if ((text_password == null) || (text_userid ==null))
            {
                throw new ArgumentException();
            }

            Regex pattern = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
        }


        public static SuperUser SuperUserCreator(string jmeno, string heslo)
        {

        }

    }
    class SuperUser
    {
        public string UserID { get; set; }
        public string Password { get; set; }

        public SuperUser(string jmeno, string heslo)
        {
            UserID = jmeno;
            Password = heslo;
        }
    }
}
