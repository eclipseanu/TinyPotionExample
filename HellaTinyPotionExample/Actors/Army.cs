using System.Collections;
using System.Collections.Generic;

namespace HellaTinyPotionExample
{
    public class Army : IEnumerable<Actor>,IActor
    {
        public Army()
        {
            _actors = new List<Actor>();
        }
        public void Add(Actor actor) => _actors.Add(actor);
        
        public IEnumerator<Actor> GetEnumerator() => _actors.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        List<Actor> _actors;
        public void Drink(Potion potion)
        {
            foreach (var actor in _actors) actor.Drink(potion);
        }

        public void UndoEffectsOf(Potion potion)
        {
            foreach (var actor in _actors) actor.UndoEffectsOf(potion);
        }

        public void Save()
        {
            foreach (var actor in _actors)
            {
                actor.Save();
            }
        }

        public void AddRange(params Npc[] npcs) => _actors.AddRange(npcs);
    }
}