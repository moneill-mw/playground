using System;

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
