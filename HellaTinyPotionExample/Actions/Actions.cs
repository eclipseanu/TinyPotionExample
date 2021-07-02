using System.Collections;
using System.Collections.Generic;

namespace HellaTinyPotionExample
{
    public class Actions : IEnumerable<Command>
    {
        readonly Persistence _persistence;
        public void DrinkPotion(IActor actor, Potion potion) => Perform(new DrinkPotion(actor,potion));

        public void SaveTheGame() => Perform(new SaveTheGame(_persistence));
        public void Undo()
        {
            if(_commands.Count > 0) _commands.Pop().Undo();
        }
        
        public void Perform(Command command)
        {
            command.Execute();
            if(command.CanUndo)
                _commands.Push(command);
        }

        public Actions(Persistence persistence)
        {
            _persistence = persistence;
            _commands = new Stack<Command>();
        }

        public IEnumerator<Command> GetEnumerator() => _commands.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        Stack<Command> _commands;
    }
}