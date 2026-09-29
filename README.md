# 2D Pixel Platformer

A 2D side-scrolling action platformer developed in Unity. The game combines platforming, ranged combat, enemy AI, environmental hazards, collectibles, checkpoints, and menu/game-flow systems.

## 🎮 Game Overview

The player explores a pixel-art environment, fights enemies using a bow and arrow, collects oranges, avoids environmental hazards, uses checkpoints, crosses a river using a moving platform, and reaches the final door to complete the level.

### Main Gameplay Flow

```text
Start Menu
   ↓
Play
   ↓
Explore Level
   ↓
Fight Enemies
   ↓
Collect Oranges
   ↓
Avoid Hazards
   ↓
Use Checkpoints
   ↓
Cross River Using Moving Platform
   ↓
Reach Final Door
   ↓
Victory
```

If the player's health reaches zero, the game displays the Game Over screen.

## 🛠️ Development Tools

- **Game Engine:** Unity 2022.1
- **Programming Language:** C#
- **Camera System:** Cinemachine 2
- **Physics:** Unity 2D Physics / Rigidbody2D
- **Level Construction:** Unity Tilemap
- **UI:** Unity Canvas and UI components
- **Animation:** Unity Animator and Animation Events
- **Audio:** Unity AudioSource / AudioClip

## 🕹️ Controls

| Input | Action |
|---|---|
| A / D | Move left / right |
| Left / Right Arrow | Move left / right |
| Space | Jump |
| Left Mouse Button | Attack / Fire Arrow |

## ⚔️ Gameplay Features

### Player System
- Horizontal movement
- Jumping and gravity-based physics
- Ground detection
- Player animation states
- Bow and arrow attack
- Projectile spawning and movement
- Health system
- Hurt and death animations
- Checkpoint respawning

### Enemy System
The game contains two enemy types.

**Melee Enemy**
- Ground-based patrol
- Ground detection using raycasting
- Player detection using `Physics2D.OverlapCircle()`
- Player chasing
- Attack behaviour
- Health and damage system
- Hurt and death animations

**Ranged Enemy**
- Long-range player detection
- Attack animation
- Fire-rate cooldown
- Animation Event based arrow firing
- Direction-based projectile movement
- Health and death system

## 🌍 Environment

The level includes:

- Tilemap-based terrain
- Platforms
- Water hazards
- Saw hazards
- Checkpoints
- Moving platform for river crossing
- Final level door

Water reduces the player's health and returns the player to the active checkpoint when health remains. When the player's health reaches zero, the death sequence and Game Over screen are triggered.

## ❤️ Health & Checkpoints

The player has a maximum of **5 health points**.

Checkpoints store their position using a `Transform`. When activated, the checkpoint becomes the player's new respawn point and restores the player's health.

The game also includes a visual heart-based health bar.

## 🍊 Collectibles

Oranges can be collected throughout the level.

When the player collects an orange:

- The orange is removed from the level.
- The orange counter increases.
- A collection sound effect is played.
- The UI displays the current number of collected oranges.

## 🎥 Camera

The game uses a **Cinemachine Virtual Camera**.

The camera:

- Follows the Player Transform.
- Uses a Framing Transposer.
- Uses Cinemachine's Basic Multi Channel Perlin noise for camera shake.
- Provides camera feedback when the player or enemies are hurt or defeated.

## 🔊 Audio

The project includes:

- Gameplay background music
- Main menu music
- Victory music
- Game Over music
- Button click sounds
- Player hurt sound
- Player death sound
- Enemy hurt sound
- Enemy death sound
- Checkpoint sound
- Respawn sound
- Orange collection sound

Victory and Game Over music are triggered when their respective screens appear.

## 🖥️ UI & Game Flow

The project contains:

### Start Menu
- Play
- Quit

### Gameplay UI
- Health / heart bar
- Orange counter
- Settings button

### Settings Menu
- Resume
- Restart
- Main Menu

The Settings menu pauses gameplay using `Time.timeScale = 0`.

### Game Over Screen
- Game Over display
- Restart
- Main Menu
- Dedicated Game Over music

### Victory Screen
- Victory display
- Replay
- Main Menu
- Dedicated Victory music

## 📁 Main Scenes

```text
StartMenu
SampleScene
```

`StartMenu` is the main menu scene, while `SampleScene` contains the main gameplay level.

## 📜 Main Scripts

Some of the main C# scripts used in the project include:

```text
Player.cs
Enemy.cs
Enemy2.cs
Arrow.cs
EnemyArrow.cs
Checkpoint.cs
HeartBar.cs
OrangeCounterUI.cs
AudioManager.cs
CameraShake.cs
SettingsManager.cs
StartMenu.cs
GameOverManager.cs
VictoryManager.cs
```

## 🧪 Testing

The project was tested for:

- Player movement and jumping
- Player attack and arrow spawning
- Enemy patrol and ground detection
- Enemy player detection and chasing
- Ranged enemy attacks
- Enemy and player damage
- Health UI updates
- Water hazard and checkpoint respawning
- Saw hazard damage
- Orange collection
- Moving platform behaviour
- Settings menu functions
- Game Over flow
- Victory flow
- Scene transitions
- Audio and sound effects

## 🚀 How to Run

1. Clone or download this repository.
2. Open the project using **Unity 2022.1**.
3. Open the `StartMenu` scene.
4. Make sure the scenes are included in Build Settings.
5. Press **Play** to start the game.

## 📌 Project Status

The project contains a complete playable level with player movement, combat, enemy behaviour, environmental hazards, collectibles, checkpoints, UI, audio, Game Over, Victory, and Settings systems.



