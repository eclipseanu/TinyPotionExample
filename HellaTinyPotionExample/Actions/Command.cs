namespace HellaTinyPotionExample
{
    public interface Command
    {
        void Execute();
        void Undo();
        
        bool CanUndo { get; }
    }
}