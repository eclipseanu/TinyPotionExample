namespace HellaTinyPotionExample
{
    public class Player : Actor
    {
        public Player(Identity identity,Persistence persistence) : base(identity,persistence)
        {
            Stats.Add("Health",100);
            Flags.Add("Invincibility");
            Flags.Add("Dead");
        }
    }
}