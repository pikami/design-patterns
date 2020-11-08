using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Prototype
{
    public class Person : IPrototype
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public IPrototype shallowClone()
        {
            return (Person)this.MemberwiseClone();
        }

        public IPrototype deepClone()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }
    }
}
