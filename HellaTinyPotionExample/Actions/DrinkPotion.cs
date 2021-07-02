namespace HellaTinyPotionExample
{
    public class DrinkPotion : Command
    {
        readonly IActor _actor;
        readonly Potion _potion;

        public DrinkPotion(IActor actor,Potion potion)
        {
            _actor = actor;
            _potion = potion;
        }
        
        public void Execute() => _actor.Drink(_potion);
        public void Undo() => _actor.UndoEffectsOf(_potion);
        public bool CanUndo => true;
    }
}