using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnageAPI.Exceptions
{
    public class RessourceException : Exception
    {
        public int Statu { get; set; }

        public RessourceException(int statu, string message) : base(message)
        {
            this.Statu = statu;
        }
    }
}