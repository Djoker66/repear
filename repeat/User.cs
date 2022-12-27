using System;
using System.Collections.Generic;
using System.Text;

namespace repeat
{
    internal class User
    {
        private string _username;
        private string _password;


        public User(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }

        public string UserName
        { 
            get => _username; 
            
            set 
            {
                if(IsUserName(value))
                {
                    
                   _username = value;
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (IsPass(value))
                {
                    _password = value;
                }
            }
        }

        public bool IsUserName(string name)
        {
            if(!string.IsNullOrWhiteSpace(name))
            {
                if (name.Length >= 6 && name.Length <= 25 )
                {
                    return true;
                }
                else
                { return false; }
            }
            else { return false; }
        }

        public bool IsPassLength(string pass)
        {
            if (pass.Length >= 8 && pass.Length <= 25)
            {
                return true;
            }
            else
            { return false; }

        }

        public bool HasLower(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsLower(pass[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasUpper(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsUpper(pass[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasDigit(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsDigit(pass[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPass(string pass)
        {
            if (!string.IsNullOrWhiteSpace(pass))
            {
                if (IsPassLength(pass) && HasUpper(pass) && HasLower(pass) && HasDigit(pass))
                {
                    return true;
                }
            }
            return false;
        }

        public string Showinfo()
        {
            return $"\nUsername: {UserName} ";
        }
    }
}
