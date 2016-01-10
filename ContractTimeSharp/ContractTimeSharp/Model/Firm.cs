using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractTime.Model
{
    class Firm
    {
        private int idFirm { get; set; }
        private String nameFirm { get; set; }

        public String NameFirm
        {
            get { return nameFirm; }

            set { nameFirm = value; }
        }

        public int IdFirm
        {
            get { return idFirm; }
            set { idFirm = value; }
        }

        public Firm()
        {

        }

        public Firm(int id, String name)
        {
            this.idFirm = id;
            this.nameFirm = name;
        }
    }
}
