using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    interface IUser
    {
        bool isAdmin { get; set; }
        string username { get; set; }
        string password { get; set; }
        int accountBalance { get; set; }
    }

    public enum privileges
    {
        User,
        Admin
    }

    public interface Observer
    {
        void update();
    }

    // A class that is observed
    public class User : IUser
    {        
        public string username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool isAdmin { get; set; }

        private List<Observer> observers = new List<Observer>();

        public int accountBalance { get; set; } 

        public User(string name, string pw, int balance, bool admin)
        {
            username = name;
            password = pw;
            accountBalance = balance;
            isAdmin = admin;
        }
        
        public void attachObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyObservers()
        {
            foreach (Observer o in observers)
                o.update();
        }
    }

    // A class that is observing (Admin's got insight into User's balance)
    public class Admin : IUser, Observer
    {
        public bool isAdmin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int accountBalance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void update()
        {
            
        }
    }
}
