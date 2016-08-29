# Dungeon

Procedural maze-like dungeon generator made using Unity 5.4.

To run the executable, only Dungeon.exe and the Dungeon_Data directory are needed.

To open the project in Unity, only the Assets and ProjectSettings directories are needed.

# Executable

When launching the executable there is an option to choose resolution and graphics quality, and the play button starts the dungeon generator. On start, a dungeon is generated and the player is placed at the top of a staircase leading down into the maze-like dungeon. The exit is on the opposite corner, marked by a flare. There are monsters and treasure chests randomly scattered throughout the dungeon. The controls are standard FPS (WASD to move, mouse to look around, space to jump, shift to run) and in addition, the G button generates a new dungeon, and the T button teleports the player back to the starting position. The escape key exits the application.

# Unity Project

The dungeon generation code is located in Assets/Scripts/DungeonGenerator.cs.

To open the project, Unity 5.4 is required (can be downloaded from unity3d.com). Inside the project, the scene MainScene.unity (located in Assets/Scenes/) has a dungeon generator script already set up. Dungeon dimensions can be changed, monsters and treasure can be toggled, and the "Generate Dungeon" button generates a new dungeon. When using the dungeon generator in the editor, the "Generate on Start" checkbox should be unchecked (this causes a new dungeon to be generated when starting the game, which is desirable in the executable but not in the editor).
