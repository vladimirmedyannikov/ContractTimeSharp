using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ContractTimeSharp.DAO
{
    class DAOException : System.Exception
    {
        public DAOException() :base(){ }
        public DAOException(string message) : base(message) { }
        public DAOException(string message, System.Exception innerException) : base(message, innerException) { }
    }
}
