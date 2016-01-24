using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ContractTime.Model
{
    public class Firm
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
