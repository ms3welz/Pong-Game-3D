Pong Game 3D
===
This repository contains 3D Game Pong unity files which are used for independent exercises provided by Agate Studio in the DTS FGA - Game Programming training in collaboration with Digitalent Kominfo (Kementerian Komunikasi dan Informatika / Ministry of Communication and Information) Republic of Indonesia.

## Papar Information
- Title:  `Pong Game 3D`
- Author:  [`Manuel Setyo Saputro Sriwibowo`](https://github.com/msetyo15)
- Types: `Pong`, `3D`, `Unity`, `Game`
- Files: [view](https://github.com/msetyo15/Pong-Game-3D)
- Demo Program: [view](https://msetyo15.github.io/Pong-Game-3D/)

## Game Rules
- Goal points increase if conceded
- If the goal points reach 15 players will lose and leave the arena
- Be the last player to be the winner
- A number of players 4 people
- ### Controller:
  - Player 1 : `A` & `D`
  - Player 2 : `Arrow Left` & `Arror Right`
  - Player 3 : `W` & `S`
  - Player 4 : `Arrow Down` & `Arrow Up`

## Preview
![preview](./Assets/Texture/preview.gif)

## Install & Dependence
- text editor (`recommendation: "Visual Studio 2019"`, VSCode, Sublime, etc)
- unity

## Pretrained model
| Model | Download |
| ---     | ---   |
| Font Chela One | [download](https://www.fontsquirrel.com/fonts/chela-one) |
| Logo | [download](https://cooltext.com/Logo-Design-Glossy) |
| GUI Games | [download](https://www.freepik.com/search?format=search&query=gui%20game) |
| 3D Textures | [download](https://www.texturecan.com/) |
| Sound FX | [download](https://www.youtube.com/results?search_query=sfx+game+) |


## Directory Hierarchy
```
|—— .gitattributes
|—— .gitignore
|—— Assets
|    |—— Animation
|        |—— Countdown.anim
|        |—— CountdownText.controller
|        |—— HowToPlayText.controller
|        |—— LinkButton.anim
|        |—— LinkButton.controller
|        |—— PlayerFloat.anim
|        |—— PlayerFloatText.controller
|        |—— PopUp.anim
|        |—— Scale In-Out effect.anim
|        |—— Scale In-Out effect.controller
|    |—— Fonts
|        |—— ChelaOne SDF.asset
|        |—— ChelaOne.ttf
|    |—— Material
|        |—— Ball.mat
|        |—— BluePed.mat
|        |—— Bounce.physicMaterial
|        |—— Floor.mat
|        |—— GreenPed.mat
|        |—— Pole.physicMaterial
|        |—— RedPed.mat
|        |—— Wall.mat
|        |—— YellowPed.mat
|        |—— ZeroBounce.physicMaterial
|    |—— Prefabs
|        |—— Ball (1).prefab
|        |—— Ball.prefab
|    |—— Scenes
|        |—— Game
|            |—— Lighting.asset
|            |—— Materials
|                |—— Night.mat
|                |—— ReflectionProbe-0.mat
|            |—— Night.exr
|        |—— Game.unity
|        |—— HowToPlay.unity
|        |—— MainMenu.unity
|    |—— Scripts
|        |—— BallController.cs
|        |—— BallManager.cs
|        |—— CountdownController.cs
|        |—— GameManager.cs
|        |—— GoalManager.cs
|        |—— MainMenuManager.cs
|        |—— PaddleController.cs
|        |—— PanelConroller.cs
|        |—— ScenesManager.cs
|        |—— SoundManager.cs
|    |—— Sounds
|        |—— click.wav
|        |—— collect.wav
|        |—— lose.mp3
|        |—— pingpong.wav
|        |—— pop.wav
|        |—— spawn.wav
|        |—— spring.wav
|        |—— winning.mp3
|    |—— Texture
|        |—— Ball
|            |—— concrete_0016_ao_1k.jpg
|            |—— concrete_0016_color_1k.jpg
|            |—— concrete_0016_height_1k.png
|            |—— concrete_0016_normal_directx_1k.png
|            |—— concrete_0016_normal_opengl_1k.png
|            |—— concrete_0016_roughness_1k.jpg
|        |—— Blue
|            |—— fabric_0028_ao_1k.jpg
|            |—— fabric_0028_color_1k.jpg
|            |—— fabric_0028_height_1k.png
|            |—— fabric_0028_normal_directx_1k.png
|            |—— fabric_0028_normal_opengl_1k.png
|            |—— fabric_0028_roughness_1k.jpg
|            |—— fabric_0028_subsurface_1k.jpg
|        |—— Floor
|            |—— plastic_0016_ao_1k.jpg
|            |—— plastic_0016_color_1k.jpg
|            |—— plastic_0016_height_1k.png
|            |—— plastic_0016_normal_directx_1k.png
|            |—— plastic_0016_normal_opengl_1k.png
|            |—— plastic_0016_roughness_1k.jpg
|        |—— Green
|            |—— fabric_0028_ao_1k.jpg
|            |—— fabric_0028_color_1k.jpg
|            |—— fabric_0028_height_1k.png
|            |—— fabric_0028_normal_directx_1k.png
|            |—— fabric_0028_normal_opengl_1k.png
|            |—— fabric_0028_roughness_1k.jpg
|            |—— fabric_0028_subsurface_1k.jpg
|        |—— Pillar
|            |—— plastic_0007_ao_1k.jpg
|            |—— plastic_0007_color_1k.jpg
|            |—— plastic_0007_height_1k.png
|            |—— plastic_0007_normal_directx_1k.png
|            |—— plastic_0007_normal_opengl_1k.png
|            |—— plastic_0007_roughness_1k.jpg
|        |—— ponglogo.jpg
|        |—— preview.gif
|        |—— Red
|            |—— fabric_0028_ao_1k.jpg
|            |—— fabric_0028_color_1k.jpg
|            |—— fabric_0028_height_1k.png
|            |—— fabric_0028_normal_directx_1k.png
|            |—— fabric_0028_normal_opengl_1k.png
|            |—— fabric_0028_roughness_1k.jpg
|            |—— fabric_0028_subsurface_1k.jpg
|        |—— UI
|            |—— bg-pong.png
|            |—— Board.png
|            |—— Button.png
|            |—— exit.png
|            |—— Jelly.png
|            |—— JellyButton.png
|            |—— media-pause-th.png
|            |—— MediaIcon_1.png
|            |—— MediaIcon_2.png
|            |—— pong.png
|        |—— Yellow
|            |—— fabric_0028_ao_1k.jpg
|            |—— fabric_0028_color_1k.jpg
|            |—— fabric_0028_height_1k.png
|            |—— fabric_0028_normal_directx_1k.png
|            |—— fabric_0028_normal_opengl_1k.png
|            |—— fabric_0028_roughness_1k.jpg
|            |—— fabric_0028_subsurface_1k.jpg
|—— Packages
|    |—— manifest.json
|    |—— packages-lock.json
|—— ProjectSettings
|    |—— AudioManager.asset
|    |—— ClusterInputManager.asset
|    |—— DynamicsManager.asset
|    |—— EditorBuildSettings.asset
|    |—— EditorSettings.asset
|    |—— GraphicsSettings.asset
|    |—— InputManager.asset
|    |—— NavMeshAreas.asset
|    |—— PackageManagerSettings.asset
|    |—— Physics2DSettings.asset
|    |—— PresetManager.asset
|    |—— ProjectSettings.asset
|    |—— ProjectVersion.txt
|    |—— QualitySettings.asset
|    |—— SceneTemplateSettings.json
|    |—— TagManager.asset
|    |—— TimeManager.asset
|    |—— UnityConnectSettings.asset
|    |—— VersionControlSettings.asset
|    |—— VFXManager.asset
|    |—— XRSettings.asset
|—— README.md
```
## Code Details
### Tested Platform
- software
  ```
  OS: Microsoft Windows 10 Pro (Build 19044)
  Visual Studio 2019: 16.11
  Unity: 2020.3.28f1
  ```
- hardware
  ```
  CPU: AMD Ryzen 3 2200G
  GPU: Radeon Vega Graphics
  ```