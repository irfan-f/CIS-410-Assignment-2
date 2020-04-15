Assignment 2
Author: Irfan Filipovic (solo project)
Particle Effect: All the gargoyles have red particles on their flashlights/
colliders. This is to imporve the hitbox visual so user has more enjoyment.
enabled on normal game start.
	Code for above can be found in /Assets/Prefabs/PointOfView
	Code to start system is found in /Assets/Scripts/Observer
	In Start() function

Dot Product: Calculate angle to the GameEnd object, if within ACOS(0.995f)
then broken compass displays: end to right, else broken compass is broken.
Enabled from start.
	Code for above can be found in /Assets/Scripts/PlayerMovement
	Majority of implementation lines 42-53

Linear Interp: Ghost(1) (the one in the second hallway, which moves up and down with two rooms to its right for hiding) has its increments of path 
calulated using linear interp, depending on which increment it crosses the 
spot light changes color. Enabled from start.
	Code for above can be found in /Assets/Scripts/GhostOneInterp
	As it is GameObject Ghost(1)
