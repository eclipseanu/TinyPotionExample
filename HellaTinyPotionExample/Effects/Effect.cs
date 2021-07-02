using System;

namespace HellaTinyPotionExample
{
    public class Effect : IEffect
    {
        readonly Action<Actor> _apply;
        readonly Action<Actor> _remove;

        public Effect(Action<Actor> apply,Action<Actor> remove)
        {
            _apply = apply;
            _remove = remove;
        }
        public void ApplyTo(Actor actor) => _apply?.Invoke(actor);

        public void RemoveFrom(Actor actor) => _remove?.Invoke(actor);
    }
}