# A Questionable Implementation of Adventure Island
Lucas O'Leary
100790165

# Gameplay Loop
- When you spawn, there is an enemy in the middle of the map. If you run into him, you take damage, losing 1 HP. If you lose all 5 HP, you lose. To defeat the enemy, you must jump on the top of their head, which will damage them instead of yourself, and you win the game.

<img width="768" height="480" alt="AdventureIslandnt" src="https://github.com/user-attachments/assets/fbfa9eec-eae6-45a7-9148-752fa67338ff" />

# Reflection
- The game uses a Game Manager script to run repeated, common functions. This script handles things like giving/receiving damage, and the win/loss states.
- I believe that this design pattern is indeed beneficial for this purpose, as those functions can be used by multiple things, whether it's enemies or players. This leads to cleaner, easier to follow code, and a centralized script to keep track of important values within the game.

# Important Note
- As I really don't like wasting space on my laptop's drive (a blank Unity project is a couple GBs), I use this repository for any 2D projects that need to be done. For this assignment, the scene is "AdventureIsland" in the scenes folder, while the scripts can be found under /Scripts/AdventureIsland/. All other folders are from previous tutorials or assignments.
- The controls are Left/Right arrow to move, and space to jump
