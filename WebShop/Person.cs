using System.Collections.Generic;

namespace WebShop
{
    internal abstract class Person
    {
        public string _name = string.Empty;
        public string _surname = string.Empty;
        public string _email = string.Empty;
        public string _password = string.Empty;

        public Address _address = new();
    }
}
