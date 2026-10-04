# Simple Android Game - Browser-Based Unity Development

A complete guide to build a simple Android game using Unity Editor in Browser (via cloud platforms) and export directly to Android.

## 🎮 Game Overview
- Type: Tap-to-Collect Game (Simple & Fun)
- Mechanics: Tap the screen to collect falling coins, avoid obstacles
- Target: Android devices (7.0+)
- Development: Browser-based (No PC required)

## 🌐 Browser-Based Development Options

### Option 1: Unity Personal Cloud (Recommended) ⭐
1. Go to Unity Cloud Dashboard
2. Sign in with your Unity account (create a free account if needed)
3. Create a new project or open an existing cloud project
4. Use the browser-based Unity Editor if available in your region
5. Build and export the Android APK from the dashboard

### Option 2: PlayCanvas
1. Create a free PlayCanvas account
2. Build your game in the browser
3. Export or package for Android-compatible deployment

### Option 3: Godot Web Editor
1. Open the Godot web editor (if available)
2. Build a lightweight mobile game
3. Export to Android-compatible APK

## 📋 Project Structure

```
simple-android-game-unity/
├── Assets/
│   ├── Scripts/
│   │   ├── GameManager.cs
│   │   ├── PlayerController.cs
│   │   ├── CoinSpawner.cs
│   │   └── UIManager.cs
│   ├── Prefabs/
│   │   ├── Coin.prefab
│   │   └── Obstacle.prefab
│   ├── Scenes/
│   │   └── GameScene.unity
│   └── UI/
│       └── Canvas.prefab
├── ProjectSettings/
│   └── ProjectVersion.txt
├── BUILD_INSTRUCTIONS.md
├── AndroidBuildSettings.json
└── README.md
```

## 🚀 Quick Start Steps

### Step 1: Setup a Unity Cloud Project
- Go to Unity Dashboard
- Create a cloud project
- Select a 2D template
- Open the editor in the browser

### Step 2: Create the game scene
- Create a ground plane and UI elements
- Add a player object
- Add coin and obstacle spawners
- Set touch controls for mobile

### Step 3: Configure Android build
- File → Build Settings
- Select Android
- Add the scene to build
- Set package name and minimum API level
- Build the APK

### Step 4: Test on Android device
- Download APK to your phone
- Enable installation from unknown sources if needed
- Install and play

## 📱 Android Export Checklist
- Minimum API level: 21+
- Target API level: 33+
- Screen orientation: Portrait
- Recommended resolution: 1080x1920
- Build type: APK for testing
- App name: Tap Coins
- Package name example: com.example.tapcoins

## 💾 Best Option for You
Since you only have an Android device and no PC, the best path is:
1. Use Unity Cloud / browser Unity editor
2. Build the game there
3. Export APK
4. Install on your Android phone

## 📚 Example Unity C# Scripts

### GameManager.cs
```csharp
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverPanel;
    public bool isGameOver;

    public void AddScore(int points)
    {
        if (isGameOver) return;
        score += points;
        scoreText.text = "Score: " + score;
    }

    public void EndGame()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
    }
}
```

### PlayerController.cs
```csharp
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float leftLimit = -3f;
    public float rightLimit = 3f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 pos = Camera.main.ScreenToWorldPoint(touch.position);
            pos.z = 0;
            pos.x = Mathf.Clamp(pos.x, leftLimit, rightLimit);
            transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * 8f);
        }
    }
}
```

### CoinSpawner.cs
```csharp
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnRate = 1f;
    public float minX = -3f;
    public float maxX = 3f;

    void Start()
    {
        InvokeRepeating("SpawnCoin", 0.5f, spawnRate);
    }

    void SpawnCoin()
    {
        Vector3 pos = new Vector3(Random.Range(minX, maxX), 6f, 0);
        Instantiate(coinPrefab, pos, Quaternion.identity);
    }
}
```

### UIManager.cs
```csharp
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
```

## 🎯 Features to include
- Collect coins with tap/click
- Score counter
- Game over panel
- Restart button
- Smooth movement on touch
- Simple, mobile-friendly UI

## 🔗 Useful Links
- Unity Cloud: https://cloud.unity.com/
- Unity Android Build Guide: https://docs.unity3d.com/Manual/android-build-process.html
- Unity Input docs: https://docs.unity3d.com/ScriptReference/Input.html

## 🧩 Final Recommendation
If you want a true Android game from your phone only, the easiest realistic path is:
- Use Unity Cloud Editor in browser
- Build a tiny 2D game
- Export APK
- Install it directly on your Android device

This repository contains the project description and code fragments you can use when setting up the Unity project in the browser.
