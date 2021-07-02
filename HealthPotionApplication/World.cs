using System.Collections.Generic;

namespace HellaTinyPotionExample
{
    public class World
    {
        
        
        
        public void Add(IActor actor) => _actors.Add(actor);

        public void Save()
        {
            foreach (var actor in _actors) 
                actor.Save();
            _actions.SaveTheGame();
        }

        public World(Persistence persistence)
        {
            _actors = new List<IActor>();
            _actions = new Actions(persistence);
        }

        readonly List<IActor> _actors;

        public void UndoLastAction() => _actions.Undo();

        public Actions Actions => _actions;

        readonly Actions _actions;
    }
}