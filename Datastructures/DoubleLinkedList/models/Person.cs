using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList.models
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public Person() : this("", "", DateTime.MinValue) { }
        public Person(string firstname, string lastname, DateTime birthdate)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Birthdate = birthdate;
        }

        public override string ToString()
        {
            return this.Firstname + " " + this.Lastname + " " + this.Birthdate.ToLongDateString();
        }
        
        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }
        public bool Equals(Person obj)
        {
            if (obj == null)
            {
                return false;
            }
            if ((obj.Firstname == this.Firstname) && (obj.Lastname == this.Lastname) && (obj.Birthdate == this.Birthdate))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = -1786895991;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Firstname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Lastname);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime>.Default.GetHashCode(Birthdate);

            return hashCode;
        }
    }
}
