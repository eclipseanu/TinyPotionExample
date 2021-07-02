using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HellaTinyPotionExample
{
    [Serializable]
    public class Flags : IEnumerable<Flag>
    {
        public Flags() => _flags = new List<Flag>();

        public void Add(string name) => Add(name, false);
        public void Add(Flag flag) => _flags.Add(flag);
        public void Add(string name, bool status) => _flags.Add(new Flag {Name = name, Status = status});

        public bool this[string name]
        {
            get => Find(name)?.Status ?? false;
            set
            {
                var found = Find(name);
                if (found != null) found.Status = value;
                else Add(name,value);
            }
        } 
        
        Flag Find(string name) =>_flags.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        
        public IEnumerator<Flag> GetEnumerator() => _flags.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        List<Flag> _flags;
    }
}