using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account
{    

    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();
        public List<Observer> observers = new List<Observer>();

        public Form1()
        {
            InitializeComponent();

            User kokos = new User("kokos", "pass", 100000, false);
            User tomek = new User("tomek", "pass1", 200, false);

            users.Add(kokos);
            users.Add(tomek);

            observers.Add()
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            bool userExists = false;
            bool passwordCorrect = false;

            foreach(User u in users)
            {
                if(u.username == username)
                {
                    userExists = true;
                    if (u.password == password)
                        passwordCorrect = true;
                }
            }

            if(userExists && passwordCorrect)
            {
                BankAccountSheet sheet = new BankAccountSheet();
                
            }
        }
    }
}
