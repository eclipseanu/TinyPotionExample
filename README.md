# TinyPotionExample
Simple Example of flags, stats, potions, world actions and persistence that supports undo

It runs this game logic:



```cs
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
```

generates this save data:

```json
[
  {
    "Stats": [
      {
        "Max": 100,
        "Value": 100,
        "Name": "Health"
      }
    ],
    "Flags": [
      {
        "Name": "Invincibility",
        "Status": false
      },
      {
        "Name": "Dead",
        "Status": false
      }
    ],
    "Identity": {
      "Name": "Jeff the Bard"
    }
  },
  {
    "Stats": [
      {
        "Max": 100,
        "Value": 0,
        "Name": "Health"
      }
    ],
    "Flags": [
      {
        "Name": "Invincibility",
        "Status": true
      },
      {
        "Name": "Dead",
        "Status": false
      }
    ],
    "Identity": {
      "Name": "Elara the Soldier"
    }
  },
  {
    "Stats": [
      {
        "Max": 120,
        "Value": 0,
        "Name": "Health"
      }
    ],
    "Flags": [
      {
        "Name": "Invincibility",
        "Status": false
      },
      {
        "Name": "Dead",
        "Status": false
      }
    ],
    "Identity": {
      "Name": "Jeff the Duck Fancier"
    }
  },
  {
    "Stats": [
      {
        "Max": 120,
        "Value": 0,
        "Name": "Health"
      }
    ],
    "Flags": [
      {
        "Name": "Invincibility",
        "Status": false
      },
      {
        "Name": "Dead",
        "Status": false
      }
    ],
    "Identity": {
      "Name": "Shegorath the Carpenter"
    }
  },
  {
    "Stats": [
      {
        "Max": 120,
        "Value": 0,
        "Name": "Health"
      }
    ],
    "Flags": [
      {
        "Name": "Invincibility",
        "Status": false
      },
      {
        "Name": "Dead",
        "Status": false
      }
    ],
    "Identity": {
      "Name": "Temptation the Cat Whisperer"
    }
  },
  {
    "Stats": [
      {
        "Max": 120,
        "Value": 0,
        "Name": "Health"
      }
    ],
    "Flags": [
      {
        "Name": "Invincibility",
        "Status": false
      },
      {
        "Name": "Dead",
        "Status": false
      }
    ],
    "Identity": {
      "Name": "Temptation the Blacksmith"
    }
  },
  {
    "Stats": [
      {
        "Max": 120,
        "Value": 0,
        "Name": "Health"
      }
    ],
    "Flags": [
      {
        "Name": "Invincibility",
        "Status": false
      },
      {
        "Name": "Dead",
        "Status": false
      }
    ],
    "Identity": {
      "Name": "Ergoth the Blacksmith"
    }
  }
]
```
