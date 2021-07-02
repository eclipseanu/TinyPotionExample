namespace HellaTinyPotionExample
{
    public class NoPersistence : Persistence
    {
        public void Add(SaveData data)
        {
            
        }

        public void Save()
        {
            
        }

        public static NoPersistence Instance => _instance ?? (_instance = new NoPersistence());
        static NoPersistence _instance;
    }
}