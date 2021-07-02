using System;

namespace HellaTinyPotionExample
{
    public class ChangeStatValue : IEffect
    {
        readonly string _statName;
        readonly Func<Stat, int> _valuePicker;

        public ChangeStatValue(string statName,Func<Stat,int> valuePicker)
        {
            _statName = statName;
            _valuePicker = valuePicker;
        }

        int _valueToSet;
        int _oldValue;
        public void ApplyTo(Actor actor)
        {
            var stat = actor.Stats[_statName];
            _valueToSet = _valuePicker?.Invoke(stat) ?? stat.Value;
            _oldValue = stat.Value;
            stat.Value = _valueToSet;
        }

        public void RemoveFrom(Actor actor) => actor.Stats[_statName].Value = _oldValue;
    }
}