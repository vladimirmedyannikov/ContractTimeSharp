using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContractTime.Model
{
    public class Department
    {
        public int idDepartment { get; set ; }
        public String nameDepartment { get; set; }
        public Firm firmDepartment { get; set; }
        public Department parentDepartment { get; set; }
        
        public Department()
        {

        }

        public override string ToString()
        {
            return nameDepartment;
        }
    }
}
