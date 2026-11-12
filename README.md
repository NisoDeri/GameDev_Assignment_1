Game Development in Game Engines Assignment 1

Out of the Box: The story

At night the board games on the table wake up. You are a white pawn that wandered out of its box and got lost
on the green felt. A red pawn has noticed you and wants to knock you off the table Between you and the box
there are chips worth 50 20 or 10 points and the dealer keeps handing out new ones in batches of five
Collect 1000 points and you are crowned. Get caught first and it is over


the game uses straightfoward WASD movement
all assignment requirements are met:

White capsule, moved with WASD PlayerMovement.Update reads Keyboard.current (normalized Vector2) White capsule sprite on the Player object
Red capsule that constantly chases the player speed editable EnemyChase.FixedUpdate moves towards the player public float speed
Coin is a circle created at runtime from one prefab with Instantiate Assets/Prefabs/Coin.prefab CoinSpawner.SpawnCoin calls Instantiate
3 coin types: value and color set in the Inspector, type chosen randomly when created
Batch of 5 at start when all 5 are collected a new batch
Random positions inside an editable range CoinSpawner.spawnMin  spawnMax Random.Range for x and y
Player touches coin → Destroy. Enemy touches player → you lose. Target reached → you won
only the player collects a coin
Player and enemy move with Rigidbody2D in FixedUpdate


Call flow: Coin → GameManager → CoinSpawner and Enemy → GameManager

I added 3 extensions 
Knight appears from level 3 with chess knight move in L shape.
Added score tracking UI to the game
Restart ability when game ends with R button.
