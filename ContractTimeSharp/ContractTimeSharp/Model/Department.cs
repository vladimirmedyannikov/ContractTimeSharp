using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractTime.Model
{
    class Department
    {
        private int idDepartment { get; set; }
        private String nameDepartment { get; set; }
        private Firm firmDepartment { get; set; }
        private Department parentDepartment { get; set; }
        
        public Department()
        {

        }
    }
}
