using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities
{
   public class User
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public User(string name)
        {
            this.name = name;
        }
    }
}
