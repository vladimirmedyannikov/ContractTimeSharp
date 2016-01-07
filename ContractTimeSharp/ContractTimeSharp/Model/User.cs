using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractTime.Model
{
    class User
    {
        private int id;
        private String fullName { get; set; }
        private String firstName { get; set; }
        private String secondName { get; set; }
        private String thirdName { get; set; }
        private DateTime dateBirthday { get; set; }
        private DateTime dateIn { get; set; }
        private DateTime dateOut { get; set; }
        private String login { get; set; }
        private String password { get; set; }
        private Department department { get; set; }
        private String email { get; set; }

        public User()
        {

        }
        public User(int idUser)
        {
            this.id = idUser;
        }
    }
}
