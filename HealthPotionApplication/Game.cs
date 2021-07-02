using System.Diagnostics;
using System.IO;
using HellaTinyPotionExample.Saving;

namespace HellaTinyPotionExample
{
    public class Game
    {
        string SavePath => @"C:\Json\GameSave.json";
        
        public void Run()
        {
            var player = _actors.CreatePlayer();
            var npc = _actors.CreateNpc();
            var army = _actors.CreateArmy(5);
            
            _world.Add(player);
            _world.Add(npc);
            _world.Add(army);
            
            _world.Actions.DrinkPotion(player,_potions.Healing());
            _world.Actions.DrinkPotion(npc,_potions.Invincibility());
            _world.Actions.DrinkPotion(army,_potions.Vitality());
            _world.Actions.DrinkPotion(army,_potions.Death());

            _world.UndoLastAction();
            _world.Save();
            OpenSaveFile();
        }

        #region Plumbing

        void OpenSaveFile() => Process.Start("explorer.exe", SavePath);
        
        public Game()
        {
            var persistence = new BasicJsonPersistence(SavePath);
            
            _actors = new ActorFactory(persistence, new IdentityGenerator());
            _potions = new PotionFactory();
            _world = new World(persistence);
        }
        
        ActorFactory _actors;
        PotionFactory _potions;
        World _world;
        #endregion

    }
}