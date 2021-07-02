using System;

namespace HellaTinyPotionExample
{
    public class ApplyStatEffect : IEffect
    {
        readonly string _statName;
        readonly Action<Stat> _perform;
        readonly Action<Stat> _undo;

        public ApplyStatEffect(string statName,Action<Stat> perform,Action<Stat> undo)
        {
            _statName = statName;
            _perform = perform;
            _undo = undo;
        }
        public void ApplyTo(Actor actor)
        {
            Stat stat = actor.Stats[_statName];
            _perform?.Invoke(stat);
        }

        public void RemoveFrom(Actor actor)
        {
            Stat stat = actor.Stats[_statName];
            _undo?.Invoke(stat);
        }
    }
}