using System;

namespace HellaTinyPotionExample
{
    public class ChangeStatMax : IEffect
    {
        readonly string _statName;
        readonly Func<Stat, int> _valuePicker;

        public ChangeStatMax(string statName,Func<Stat,int> valuePicker)
        {
            _statName = statName;
            _valuePicker = valuePicker;
        }

        int _maxToSet;
        int _oldValue;
        public void ApplyTo(Actor actor)
        {
            var stat = actor.Stats[_statName];
            _maxToSet = _valuePicker?.Invoke(stat) ?? stat.Max;
            _oldValue = stat.Max;
            stat.Max = _maxToSet;
        }

        public void RemoveFrom(Actor actor) => actor.Stats[_statName].Value = _oldValue;
    }
}