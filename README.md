# Codec Test: Mars Hover

## Test Description
You need to develop a robot that will navigate on Mars terrain.

The input of the app will be a series of commands to move the robot on the plateau. Mars plateau is a grid defined by the initial input of the app, such as 5x5, 3x4, etc.

The second input line will be a string containing multiple commands as described below:

- L: Turn the robot left

- R: Turn the robot right

- F: Move forward on it's facing direction



Sample command string: LFLRFLFF

The robot will always start at X: 1, Y: 1 facing NORTH. If the robot reaches the limits of the plateau the command must be ignored.

Your goal is to navigate the robot and print the final position.

_Assumption: Turns are made by 90 degrees_

### Example:

Input:

5x5

FFRFLFLF

Result:

1,4,West

There is no limit for the Plateau size

Inputs will always be valid
