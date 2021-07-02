using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace HellaTinyPotionExample.Saving
{

    public class BasicJsonPersistence : Persistence
    {
        readonly string _filePath;
        readonly HashSet<SaveData> _saveDatas;
        public BasicJsonPersistence(string filePath)
        {
            _filePath = filePath;
            _saveDatas = new HashSet<SaveData>();
        }

        public void Add(SaveData data) => _saveDatas.Add(data);
        public void Save() => SaveTo(_filePath);

        public void SaveTo(string path)
        {
            var content = ToJsonString();
            File.WriteAllText(path, content);
        }

        string ToJsonString() => JsonConvert.SerializeObject(_saveDatas, Formatting.Indented);
    }
}