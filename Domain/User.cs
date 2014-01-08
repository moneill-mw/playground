using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        private string _name;
        public User(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            _name = name;
        }

        public string Name { get { return _name; } }
    }
}
