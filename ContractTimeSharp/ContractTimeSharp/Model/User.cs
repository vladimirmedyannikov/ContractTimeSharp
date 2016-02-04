using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContractTime.Model
{
    public class User
    {
        private int id;
        private int typeUser;
        private string login;
        private string hashPass;
        public string HashPass
        {
            set { hashPass = value; }
            get { return hashPass; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public int TypeUser
        {
            get { return typeUser; }
            set { typeUser = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String fullName { get; set; }
        public String FullName
        {
            get { return secondName + " " + firstName + " " + thirdName; }
        }

        public string TypeUserStr
        {
            get { return (TypeUser == 0) ? "Пользователь" : "Администратор"; }
        }
        private String firstName { get; set; }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private String secondName { get; set; }
        public String SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        private String thirdName { get; set; }
        public String ThirdName
        {
            get { return thirdName; }
            set { thirdName = value; }
        }

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }
        
        private DateTime dateBirthday { get; set; }
        private DateTime dateIn { get; set; }
        private DateTime dateOut { get; set; }
        public String Password { get; set; }
        private Department department { get; set; }
        private String email { get; set; }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Appointment { get; internal set; }

        public User()
        {

        }
        public User(int idUser)
        {
            this.id = idUser;
        }

        public override string ToString()
        {
            return this.FullName;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(User))
            {
                return this.id == ((User)obj).id;
            }
            else return false;
        }
    }
}
