namespace HellaTinyPotionExample
{
    public interface IActor
    {
        void Drink(Potion potion);
        void UndoEffectsOf(Potion potion);

        void Save();
    }
}