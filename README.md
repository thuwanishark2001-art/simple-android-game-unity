# Simple Android Game - Unity Export Project

This repository contains a small Unity-ready mobile game project for a simple Android tap-to-collect game.

## Game idea
- Player moves left/right on the screen
- Coins fall from the top
- Collect coins to increase score
- Avoid obstacles or the round ends
- Built for Android and exportable from Unity

## Files included
- `README.md` — overview and instructions
- `BUILD_INSTRUCTIONS.md` — Unity browser/cloud export instructions
- `Assets/Scripts/GameManager.cs` — score and game state logic
- `Assets/Scripts/PlayerController.cs` — touch movement and collision handling
- `Assets/Scripts/CoinSpawner.cs` — spawns falling coins
- `Assets/Scripts/Coin.cs` — coin behavior and score trigger
- `Assets/Scripts/UIManager.cs` — score panel / restart flow

## Recommended workflow for your situation
Because you have only an Android device and no PC, the easiest path is:
1. Use Unity Cloud or browser-based Unity editor
2. Create a 2D project
3. Add the scripts from this repo
4. Build an APK to Android
5. Install the APK on your device

For exact browser and export steps, see `BUILD_INSTRUCTIONS.md`.

## Quick setup summary
1. Open Unity Cloud or Unity browser editor
2. Create a new 2D project
3. Create folders:
   - `Assets/Scripts`
   - `Assets/Scenes`
4. Copy the scripts from this repo to `Assets/Scripts`
5. Create a new scene and add:
   - Player object with `Rigidbody2D` and `BoxCollider2D`
   - CoinSpawner object
   - Canvas with score text and restart button
   - GameManager and UIManager references
6. Switch platform to Android
7. Build APK and install

## Important note
This repository contains the game logic and setup instructions; the actual Unity engine build/export still runs in the Unity editor or Unity Cloud environment.
