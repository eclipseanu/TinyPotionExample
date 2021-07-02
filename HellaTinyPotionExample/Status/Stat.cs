namespace HellaTinyPotionExample
{
    public class Stat
    {
        int _value;
        public int Max { get; set; }

        public int Value
        {
            get => _value;
            set
            {
                if (value < 0)
                    _value = 0;
                _value = value > Max ? Max : value;
            }
        }

        public void Fill() => Value = Max;
        public void Empty() => Value = 0;
        public void IncreaseBy(float percent) => Max = (int)(Max * percent);
        public void DecreaseBy(float percent) => Max = (int)(Max * percent);

        public string Name { get; set; }
    }
}