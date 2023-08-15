using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace H_W_Mod3_1
{
    public class Person : IComparable<Person>, IComparable
    {
        public Person() { } 
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int CompareTo(object? obj)
        {
            var b = obj as Person;
            var a = this;
            if (a == null)
            {
                if (b == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (b == null)

                {
                    return 1;
                }
                else
                {
                    int retrieval = a.Id.CompareTo(b.Id);

                    if (retrieval != 0)
                    {
                        return retrieval;
                    }
                    else
                    {
                        return a.Id.CompareTo(b.Id);
                    }
                }
            }
        }
        public override string ToString()
        {
            return $"{this.Id}\t{this.Name}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Person otherPerson)
            {
                return Id == otherPerson.Id;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() * Name.GetHashCode();
        }

        public int CompareTo(Person other)
        {
            if (this.Id < other.Id)
            {
                return -1;
            }
            else if (this.Id > other.Id)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
