# Build Instructions for Unity Android Export

This guide explains how to build a simple Android game from Unity when you are only using a browser-based or cloud Unity workflow.

## Option 1: Unity Cloud / browser-based workflow (best for your situation)

1. Open Unity Cloud
   - Visit: https://cloud.unity.com/
2. Sign in or create a Unity account
3. Create a new project
4. Select a 2D template
5. Open the project in the browser editor if available
6. Create the game scene and copy the scripts from this repository into `Assets/Scripts`
7. Configure the Android build target
8. Build the APK
9. Download the APK to your Android phone
10. Install it and test it

## Option 2: If you have access to a browser Unity editor only

1. Start a new 2D project
2. Create folders:
   - `Assets`
   - `Assets/Scripts`
   - `Assets/Scenes`
3. Add all scripts from this repo into `Assets/Scripts`
4. Create the scene objects:
   - Player
   - CoinSpawner
   - Canvas
   - Score text
   - Restart button
   - GameOver panel
5. Set the game resolution to portrait
6. Set package name: `com.yourname.tapcoins`
7. Build Android APK

## Unity scene setup

### Player setup
- Create a GameObject named `Player`
- Add `SpriteRenderer` or simple color
- Add `Rigidbody2D`
- Add `BoxCollider2D`
- Attach `PlayerController`

### Spawner setup
- Create an empty GameObject named `CoinSpawner`
- Attach `CoinSpawner`
- Set its `Coin Prefab` field to a coin prefab

### UI setup
- Create a `Canvas`
- Add `Text` objects for score and game over
- Add a button for restart
- Attach `UIManager`

### GameManager setup
- Create an empty GameObject named `GameManager`
- Attach `GameManager`
- Assign the score text and game over panel
- Assign the UI manager and player controller if required

## Android export checklist
- Platform: Android
- Minimum API: 21+
- Target API: 33+
- Screen orientation: Portrait
- Build type: APK
- App name: Tap Coins
- Package name: `com.example.tapcoins`

## Export steps in Unity
1. Open your project scene
2. Go to `File > Build Settings`
3. Select `Android`
4. Click `Switch Platform`
5. Go to `Player Settings`
6. Set package name, icons, orientation, and API level
7. Click `Build`
8. Save the APK to your device
9. Transfer or download it to your Android phone
10. Install and play

## Troubleshooting
- If the Android option is missing, install Android Build Support in Unity Hub
- If the project won't build, check the package name and API settings
- If gameplay feels wrong, adjust movement speed and spawn rate in the inspector

## Recommended simple game for your Android device
This project is built around a very lightweight 2D game:
- Player collects falling coins
- Score rises when coins are collected
- Game ends if the player touches an obstacle or falls out of bounds
- Very easy to export to APK

## Final note
This game can be built and exported from Unity Cloud or browser Unity, but the actual APK generation requires the Unity editor environment or Unity Cloud build service.
