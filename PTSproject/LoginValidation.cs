using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSproject
{
    class LoginValidation
    { 
        // class construstor
        public LoginValidation(string username, string password)
        {
            mUsername = username;
            mPassword = password;
        }

        // class methods
        public bool ValidateUserInput(ref User user)
        {
            /*
            Boolean emptyUserName = mUsername.Equals(String.Empty);
            if (emptyUserName == true)
            {
                return false;
            }
            Boolean emptyPassword = mPassword.Equals(String.Empty);
            if (emptyPassword == true)
            {
                return false;
            }
            Boolean shortUsernameAndPassword = mUsername.Length < 5 && mPassword.Length < 5;
            if (shortUsernameAndPassword)
            {
                return false;
            }
            */
            user = UserData.IsUserPassCorrect(mUsername, mPassword);
            if (user == null)
            {

                currentUserType = UserType.ANONYMOUS;
                return false;
            }
            else
            {
                currentUserType = (UserType)user.userType;
                currentUserUsername = user.username;
            }

            return true;
        }

        // class properties 
        static public UserType currentUserType
        {
            get;
            private set;
        }
        static public string currentUserUsername
        {
            get;
            private set;
        }

        // class members
        private string mUsername;
        private string mPassword;
    }
}
