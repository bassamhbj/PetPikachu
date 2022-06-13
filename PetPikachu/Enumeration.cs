using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPikachu
{
    public abstract class Enumeration : IComparable
    {
        public string Name { get; private set; }
        public int Id { get; private set; }

        protected Enumeration(int id, string name) {
            Id = id;
            Name = name;
        }

        public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
            typeof(T)
                .GetFields(System.Reflection.BindingFlags.Public)
                .Select(f => f.GetValue(null))
                .Cast<T>();

        public int CompareTo(object obj) => Id.CompareTo(((Enumeration)obj).Id);
    }
}
