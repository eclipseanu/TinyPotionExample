namespace HellaTinyPotionExample
{
    public class SetStat : IEffect
    {
        readonly string _name;
        readonly int _value;

        public SetStat(string name,int value)
        {
            _name = name;
            _value = value;
        }
        public void ApplyTo(Actor actor)
        {
            _oldValue =actor.Stats[_name].Value;
            actor.Stats[_name].Value = _value;
        }

        public void RemoveFrom(Actor actor) => actor.Stats[_name].Value = _oldValue;

        int _oldValue;
    }
}