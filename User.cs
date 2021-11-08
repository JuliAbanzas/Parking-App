using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public class User
    {
        private string userName;
        private string password;
        private DateTime lastAccess;
        private int questionid;
        private string answer;

        public User()
        {

        }

        public User (string userName, string password, int questionid, string answer)
        {
            UserName = userName;
            Password = password;
            QuestionID = questionid;
            Answer = answer;
        }

        public string UserName
        {
            get
            { return userName; }
            set
            { userName = value; }
        }

        public string Password
        {
            get
            { return password; }
            set
            { password = value; }
        }

        public DateTime LastAccess
        {
            get
            { return lastAccess; }
            set
            { lastAccess = value; }
        }

        public int QuestionID
        {
            get
            { return questionid; }
            set
            { questionid = value; }
        }

        public string Answer
        {
            get
            { return answer; }
            set
            { answer = value; }
        }

        public override string ToString()
        {
            return UserName + "\t" + LastAccess;
        }
    }
}
