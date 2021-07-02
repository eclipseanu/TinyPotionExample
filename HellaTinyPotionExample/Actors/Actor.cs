using System;

namespace HellaTinyPotionExample
{
    public class Actor : IActor
    {
        readonly Persistence _persistence;
        readonly Stats _stats;
        readonly Flags _flags;
        readonly Identity _identity;
        public Stats Stats => _stats;
        public Flags Flags => _flags;

        public Identity Identity => _identity;
        public Actor(Identity identity, Persistence persistence) : this(identity) => _persistence = persistence;

        public Actor(Identity identity)
        {
            _flags = new Flags();
            _stats = new Stats();
            _identity = identity;
        }

        public void Save()
        {
            _persistence.Add(ActorSaveData.Create(_stats, _flags,_identity));
        }
        
        public void Set(string stat, int value) => _stats[stat].Value = value;
        public void Set(string flag, bool value) => _flags[flag] = value;

        public void Drink(Potion potion) => potion.ApplyEffects(this);
        public void UndoEffectsOf(Potion potion) => potion.RemoveEffects(this);
    }

    [Serializable]
    public class SaveData
    {
        
    }

    [Serializable]
    public class ActorSaveData : SaveData
    {
        public Stats Stats { get; set; }
        public Flags Flags { get; set; }
        public Identity Identity { get; set; }

        public static ActorSaveData Create(Stats stats, Flags flags,Identity identity) => new ActorSaveData
        {
            Stats = stats,
            Flags = flags,
            Identity = identity
        };
    }
}