using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab0_EDI.Models;

namespace Lab0_EDI.Extra
{
    public sealed class Singleton
    {
        private readonly static Singleton instance = new Singleton();
        public List<Client> ClientsList;
        
        private Singleton()
        {
            ClientsList = new List<Client>();
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
