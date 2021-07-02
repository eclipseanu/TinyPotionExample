namespace HellaTinyPotionExample
{
    public class Npc : Actor
    {
        public Npc(Identity identity,Persistence persistence) : base(identity,persistence)
        {
            Stats.Add("Health",100);
            Flags.Add("Invincibility");
            Flags.Add("Dead");
        }
    }
}