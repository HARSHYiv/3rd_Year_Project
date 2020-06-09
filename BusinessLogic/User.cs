using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class User
    {
        private int UserID;
        private string Name;
        private string Surname;
        private string EmailAddress;
        private string Password;
        private int typeID;

        public List<User> users = new List<User>();
        public int UserID1 { get => UserID; set => UserID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public string EmailAddress1 { get => EmailAddress; set => EmailAddress = value; }
        public string Password1 { get => Password; set => Password = value; }
        public int TypeID { get => typeID; set => typeID = value; }

        public User()
        {

        }

        public User(object ID, Object name, object surname, object email, object password, object typeID)
        {
            this.UserID = (Int16)(ID);
            this.Name = name.ToString();
            this.Surname = surname.ToString();
            this.EmailAddress = email.ToString();
            this.Password = password.ToString();
            this.typeID = (Int16)(typeID);
        }


        public User(Int16 ID, string name, string surname, string email, string password, Int16 typeID)
        {
            this.UserID = ID;
            this.Name = name;
            this.Surname = surname;
            this.EmailAddress = email;
            this.Password = password;
            this.typeID = typeID;
        }

        public List<User> GetUsers()
        {
            //get info from data handler 
            DataSet userdata = new  DataSet();
            foreach (DataRow user in userdata.Tables["User_tbl"].Rows)
            {
                users.Add(new User(user["UserID"].ToString(), user["Name"].ToString(), user["Surname"].ToString(), user["EmailAddress"].ToString(), user["Password"].ToString(),user["TypeID"].ToString()));

            }

            return users;           
        }
    }
}
