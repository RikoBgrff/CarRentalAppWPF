using Car_Rental_App.Entities;
using Car_Rental_App.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Car_Rental_App.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=.;Initial Catalog=CarRentalDb;Integrated Security=True");
            try
            {
                if (sql.State == ConnectionState.Closed) sql.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE EmailAddress=@EmailAddress AND Password=@Password";
                SqlCommand command = new SqlCommand(query, sql);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@EmailAddress", EmailTextBox.Text);
                command.Parameters.AddWithValue("@Password", PasswordTextBox.Password);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 1)
                {
                    SendMail mailSender = new SendMail();
                    mailSender.Send(EmailTextBox.Text, MailSubject.LoginInfoMail, MailBody.LoginInfoMail);
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email or password is incorrect");
                    EmailTextBox.Text = "";
                    PasswordTextBox.Password = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
