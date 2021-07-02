namespace HellaTinyPotionExample
{
    public class ActorFactory
    {
        public Player CreatePlayer() => new Player(RandomIdentity,_persistence);

        public Npc CreateNpc() => new Npc(RandomIdentity,_persistence);
        
        public Army CreateArmy(int count)
        {
            var army = new Army();
            for (int i = 0; i < count; i++) army.Add(this.CreateNpc());
            return army;
        }
        
        public ActorFactory() : this(NoPersistence.Instance, new IdentityGenerator()) { }
        public ActorFactory(Persistence persistence,IdentityGenerator identityGenerator)
        {
            _persistence = persistence;
            _identityGenerator = identityGenerator;
        }

        Identity RandomIdentity => _identityGenerator.Create();

        readonly Persistence _persistence;
        readonly IdentityGenerator _identityGenerator;
    }

    public class IdentityGenerator
    {
        public Identity Create() => new Identity
        {
            Name = $"{Names.Random()} the {Jobs.Random()}"
        };
        
        
        string[] Jobs =
            {"Bard", "Warrior", "Cat Whisperer", "Duck Fancier", "Soldier", "Knight", "Carpenter", "Blacksmith"};
        string[] Names =
            {"Jeff", "Sarah", "Mary", "Colin", "Ergoth", "Shegorath", "Clive", "Elara", "Temptation", "Fury", "Flein"};

    }
}