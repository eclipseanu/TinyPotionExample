using System;
using System.Collections;
using System.Collections.Generic;

namespace HellaTinyPotionExample
{
    public class Potion : IEnumerable<IEffect>
    {
        public string Name;
        public string Description;
        public Potion(string name,string description = "")
        {
            Name = name;
            Description = description;
            _effects = new List<IEffect>();
        }

        public void ApplyEffects(Actor actor)
        {
            foreach (var effect in _effects) effect.ApplyTo(actor);
        }
        public void RemoveEffects(Actor actor)
        {
            foreach (var effect in _effects) effect.RemoveFrom(actor);
        }

        public void Add(string statName, Func<Stat, int> action,bool max)
        {
            _effects.Add(max ? (IEffect) new ChangeStatMax(statName, action) : new ChangeStatValue(statName, action));
        }

        public void Add(string statName, Func<Stat, int> action) => _effects.Add(new ChangeStatValue(statName, action));
        public void Add(Action<Actor> apply, Action<Actor> remove) => _effects.Add(new Effect(apply, remove));
        public void Add(string name, bool value) => _effects.Add(new SetFlag(name, value));
        public void Add(string name, int value) => _effects.Add(new SetStat(name, value));
        public void Add(IEffect effect) => _effects.Add(effect);
        
        public IEnumerator<IEffect> GetEnumerator() => _effects.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        readonly List<IEffect> _effects;
    }
}