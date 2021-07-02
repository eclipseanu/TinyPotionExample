using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HellaTinyPotionExample
{
    [Serializable]
    public class Stats : IEnumerable<Stat>
    {

        public Stats() => _stats = new List<Stat>();

        public void Add(Stat stat) => _stats.Add(stat);
        public void Add(string name, int value) => _stats.Add(new Stat {Name = name, Value = value, Max = value});
        public void Add(string name, int value,int max) => _stats.Add(new Stat {Name = name, Value = value, Max = max});

        public Stat this[string name]
        {
            get => Find(name);
            set
            {
                var found = Find(name);
                if (found != null)
                {
                    found.Value = value.Value;
                    found.Max = value.Max;
                }

            }
        }

        Stat Find(string name) =>_stats.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        
        public IEnumerator<Stat> GetEnumerator() => _stats.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        List<Stat> _stats;

        public void Fill()
        {
            foreach (var stat in _stats) stat.Fill();
        }
    }
}