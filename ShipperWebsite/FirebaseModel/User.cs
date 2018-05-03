using System;

namespace ShipperWebsite.FirebaseModel
{
    public class User
    {
        private String email;
        private String password;
        private String userID;
        private String url;
        private String permission;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }


       

        public String UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String phone;

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }
       

        public String Url
        {
            get { return url; }
            set { url = value; }
        }

   
        public String Permission
        {
            get { return permission; }
            set { permission = value; }
        }
    }
}