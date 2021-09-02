using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MrTravel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int number = 0;
        public void LoginButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Password.Text) &&
            string.IsNullOrEmpty(Email.Text))
            {
                LoginButtonMain.Text = "Please input your username and password";
            }
            else if(string.IsNullOrEmpty(Password.Text)) 
                {
                    LoginButtonMain.Text = "Please input your username";
                }
            else if (string.IsNullOrEmpty(Email.Text))
                {
                LoginButtonMain.Text = "Please input your password";
                }
            else
            {
                number += 1;
                LoginButtonMain.Text = $"You clicked me {number} times";
            }

        }

    }
}
