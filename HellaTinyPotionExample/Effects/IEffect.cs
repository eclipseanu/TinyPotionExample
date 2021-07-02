namespace HellaTinyPotionExample
{
    public interface IEffect
    {
        void ApplyTo(Actor actor);
        void RemoveFrom(Actor actor);
    }
}