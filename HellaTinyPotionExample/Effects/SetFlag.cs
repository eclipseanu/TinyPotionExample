namespace HellaTinyPotionExample
{
    public class SetFlag : IEffect
    {
        readonly string _name;
        readonly bool _value;

        public SetFlag(string name,bool value)
        {
            _name = name;
            _value = value;
        }
        public void ApplyTo(Actor actor)
        {
            _oldValue =actor.Flags[_name];
            actor.Flags[_name] = _value;
        }

        public void RemoveFrom(Actor actor) => actor.Flags[_name] = _oldValue;
        bool _oldValue;
    }
}