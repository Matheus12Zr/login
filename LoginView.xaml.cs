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

namespace login.view
{
    
    public partial class LoginView : Window
    {
            private string[] users = { "Carlos", "Evandro", "Matheus" };
            private int[] passwords = { 1234, 1234, 1234 };


            public LoginView()
            {
                InitializeComponent();
            }

            private void Window_MouseDown(object sender, MouseButtonEventArgs e)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                    DragMove();
            }
            private void btnLogin_Click(object sender, RoutedEventArgs e)
            {
                string inputUser = txtUser.Text;
                int inputPassword;

                if (int.TryParse(txtPass.Password, out inputPassword))
                {
                    int userIndex = Array.IndexOf(users, inputUser);

                    if (userIndex != -1 && passwords[userIndex] == inputPassword)
                    {
                        MessageBox.Show("Bem vindo ao OUTWAVE Music");
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.");
                    }
                }
                else
                {
                    MessageBox.Show("A senha deve ser um número.");
                }
            }


            private void btnMinimize_Click(object sender, RoutedEventArgs e)
            {
                WindowState = WindowState.Minimized;
            }

            private void btnClose_Click(object sender, RoutedEventArgs e)
            {
                Application.Current.Shutdown();
            }
        }
    }

