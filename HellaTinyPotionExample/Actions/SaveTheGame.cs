namespace HellaTinyPotionExample
{
    public class SaveTheGame : Command
    {
        readonly Persistence _persistence;

        public SaveTheGame(Persistence persistence) => _persistence = persistence;

        public void Execute() => _persistence.Save();

        public void Undo()
        {
            throw new System.NotImplementedException();
        }

        public bool CanUndo => false;
    }
}