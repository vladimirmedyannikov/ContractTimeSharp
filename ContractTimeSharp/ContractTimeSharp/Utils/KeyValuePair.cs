using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContractTimeSharp.Utils
{
    class KeyValuePair
    {
        private string key;
        private string value;

        public KeyValuePair(String key, String value)
        {
            this.key = key;
            this.value = value;
        }

        public string Key
        {
            get { return key; }
        }

        public string Value
        {
            get { return value; }
        }

        public override string ToString()
        {
            return value; 
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == typeof(KeyValuePair))
            {
                return Key.Equals(((KeyValuePair)obj).Key) ? true : false;
            }
            else return false;
        }
    }
}
