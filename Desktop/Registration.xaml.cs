using Desktop.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
            if (Validate.ValidateName(UserName.Text) == false)
            {
                
                MessageBox.Show("Incorrect name");
                
            } 
            else if(UserRepository.CheckUserName(UserName.Text))
            {
                MessageBox.Show("UserName is already token");
            }

            else if (Validate.ValidateEmail(EmailAdress.Text) == false)
            {
                MessageBox.Show("Incorrect email");
                ;
            }
            else if (UserRepository.CheckUserEmail(EmailAdress.Text))
            {
                MessageBox.Show("Email is already token");
            }
            else if (Validate.ValidatePassword(Password.Password) == false)
            {
                MessageBox.Show("Incorrect password");
                ;
            }
            else if (Password.Password != PasswordConfirm.Password)
            {
                MessageBox.Show("Passwords don't match");
                
            }
            else
            {
                UserRepository.Registration(UserName.Text, EmailAdress.Text, Password.Password);
                var MainEmptyWindow = new MainEmpty();
                MainEmptyWindow.Show();
                this.Close();
            }
           
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var LoginWindow = new LogIn();
            LoginWindow.Show();
            this.Close();
        }
    }
}
