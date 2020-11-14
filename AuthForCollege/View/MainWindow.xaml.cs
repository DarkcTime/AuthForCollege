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
using AuthForCollege.Controller;

namespace AuthForCollege
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetAuthText();

        }

        private void SetAuthText()
        {

            string role = string.Empty;

            switch (UserRepo.AuthUser.RoleId)
            {
                case 1:
                    role = "Пользователь";
                    break;
                case 2:
                    role = "Администратор";
                    break;
                case 3:
                    role = "Координатор";
                    break;
            }

            this.txtAuth.Text = $"Вы успешно авторизированы как {role}"; 
        }
    }
}
