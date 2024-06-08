# Flappy Bird with Enhancements

## Overview
This project aims to add unique enhancements to the traditional Flappy Bird game, making it more engaging and challenging. The game is developed using Unity and scripted in C#. While the core mechanics remain the same, where the bird flaps to navigate through pipes, additional features have been introduced to provide a fresh experience.

## Features
- **Flappy Bird Mechanics:** The bird flaps to move upwards and falls due to gravity, navigating through pipes.
- **Rotating Bird:** Every time the bird flaps, it rotates 90 degrees.
- **Egg Shooting:** Players can press the 'E' key to shoot eggs. Each game session allows for 5 egg shots.
  - **Pipe Destruction:** Eggs destroy pipes upon collision, clearing the bird's path.
  - **Self-Destruction Risk:** If an egg is shot while the bird is facing left, it results in the bird hitting itself, ending the game.
- **Boundary Conditions:** The game ends if the bird flies out of the designated boundaries.

## Installation
1. **Clone the Repository:**
   ```bash
   git clone https://github.com/OzkanCelikkilic/Flappy-Bird.git
