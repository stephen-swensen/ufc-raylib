namespace Swensen.SFML.Game

type Level =
    { EnemySpeed: float32
      EnemyCount: int
      EnemyDirections: (Direction option) list
      StartText: string
      PoisonCount: int }

module Levels =
    let loadAll () =
        [ { EnemySpeed = 1.5f
            EnemyCount = 4
            EnemyDirections =
                [ Some Up
                  Some Down
                  Some Left
                  Some Right ]
            PoisonCount = 0
            StartText = "Circles abound...\nYou.\nMust.\nEat them all!!" }
          { EnemySpeed = 4f
            EnemyCount = 8
            EnemyDirections =
                [ Some Up
                  Some Down
                  Some Left
                  Some Right ]
            PoisonCount = 0
            StartText = "They've learned and they've learned fast...\nTry to keep up!!" }
          { EnemySpeed = 4f
            EnemyCount = 8
            EnemyDirections =
                [ Some Up
                  Some Down
                  Some Left
                  Some Right ]
            PoisonCount = 3
            StartText = "Now, be careful..." }
          { EnemySpeed = 6f
            EnemyCount = 10
            EnemyDirections =
                [ Some Up
                  Some Down
                  Some Left
                  Some Right ]
            PoisonCount = 4
            StartText = "Things are getting a little hectic\naround here!" }
          { EnemySpeed = 10f
            EnemyCount = 12
            EnemyDirections =
                [ Some Up
                  Some Down
                  Some Left
                  Some Right ]
            PoisonCount = 5
            StartText = "Great balls of fire, this it!!!\n(hold on to your saddle)" } ]
