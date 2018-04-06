using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PTSproject
{
    class User
    {
        public User(string username, string password, UserType userType)
        {
            mUsername = username;
            mPassword = password;
            mUserType = userType;
        }
        public string username
        {
            get { return mUsername; }
            private set { }
        }
        public string password
        {
            get { return mPassword; }
            private set { }
        }
        public UserType userType
        {
            get { return mUserType; }
            private set { }
        }
        
        //members
        private string mUsername;
        private string mPassword;
        private UserType mUserType;

    }
}
