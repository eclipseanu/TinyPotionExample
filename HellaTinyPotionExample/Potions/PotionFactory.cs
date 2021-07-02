namespace HellaTinyPotionExample
{
    public class PotionFactory
    {
        public Potion Invincibility() => new Potion("Invincibility","Makes you invincible")
        {
            {"Invincibility", true}
        };

        public Potion Healing() => new Potion("Healing","Heals to full")
        {
            {"Health", x=>x.Max}
        };

        public Potion Vitality() => new Potion("Vitality","Increase Max Health by 20%")
        {
            {"Health", x => (int)(x.Max * 1.2f), true}
        };

        public Potion Death() => new Potion("Death", "Kills you")
        {
            {"Dead", true}
        };
    }
}