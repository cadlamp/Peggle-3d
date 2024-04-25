# Peggle3D
A recreation of the game "Peggle", but in 3D! Artifact project for CSE 457 at the University of Washington.

# Features
- A cannon whose direction can be controlled using WASD and arrow keys and can launch cannon balls using left click.
  - The cannon has a firing animation and emits particles when fired.
- Multiple camera views. The user is able to toggle between cameras using the “tab” key. There are three cameras the user can control:
  - An adjustable camera that points towards the center of the stage. The user is able to change the angle of the camera using right click and the zoom using the scroll wheel.
  - A camera with a crosshair that is placed at the tip of the cannon. 
  - An adjustable camera that points towards the most recently fired ball. The controls are the same as the first camera.
- Multiple levels consisting of target spheres that cannonballs can bounce off
  - When target spheres are hit, their color fades and then they disappear after a certain time. When they disappear, they perform a shrinking animation and emit some particles.
  - The win condition is to hit all the purple target spheres with the limited number of cannon balls you have. You lose if you run out of cannon balls without hitting all the purple spheres.
- Players have the ability to reset the level when they lose or win, and are able to move to the next level when they win.
  - There are 3 levels in total.
  - For each level, players earn 10 points for each target sphere they hit, and 3 points for the other spheres. The points are displayed on the screen.

# Environment
Unity 2022.3.18f1 was used for this project.
