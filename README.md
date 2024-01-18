# Roller Splat

**About:**
Roller Splat is an exciting Unity game that challenges players to navigate a ball through a maze of uncolored tiles. Your goal is to roll over each tile, coloring it, and completing the level. With intuitive controls, vibrant visuals, and engaging gameplay, Roller Splat provides a thrilling experience of puzzle-solving and color-matching.

## Components

### 1. PlayMusicShot
This script handles playing audio cues, such as level-win sounds, based on game events.

### 2. GameManager
The GameManager script manages the game state, level progression, and completion checks. It also handles scene loading and audio playback.

### 3. BallController
BallController script controls the movement of the ball. It uses swipe gestures for directional input, and the ball colors tiles as it rolls over them.

### 4. GroundPiece
GroundPiece script is attached to each tile in the game. It tracks whether a tile is colored and notifies the GameManager when all tiles are colored to complete the level.

### 5. MusicLoop
MusicLoop script manages the continuous looping of background music throughout the game. It plays level-win audio cues triggered by the GameManager.

## How to Play

- Swipe on the screen to roll the ball in the desired direction.
- Color all tiles by rolling over them.
- Complete each level to progress to the next one.
- Enjoy the challenging puzzles and vibrant colors!

**Note:** This readme provides an overview of the main scripts and their functionalities. Detailed implementation and specific features may require further exploration of the codebase.
