# KITCHEN CHAOS TUTORIAL BY CODE MONKEY

```
https://www.youtube.com/watch?v=AmGSEH7QcDg&t=4149s
```

- Progress 04/12/2024: 1:22:00;

  - Created project
  - Imported assets
  - Setup post processing
  - Setup player with legacy input
  - Setup player movement and rotation

- Progress 04/14/2024: 2:38:20;

  - Setup animations for idle and walking
  - Setup Cinemachine camera
  - Refactored to new input system
  - setup for WASD and Controller input
  - Setup raycasts for collision detection
  - Created clear counter prefab
  - Setup interactable handling with raycasts & layers

- Progress 04/28/2024: 3:24:52

  - Created interact events to handle player interacting with clear counters
  - Used singleton pattern for selected counter visual
  - Setup scriptable objects for spawning ingredients

- Progress 04/28/2024: 3:49:24

  - Implemented Kitchen object parent class
  - used interfaces to allow player object to be set as kitchen object parent
    just like the counter

- Progress 05/11/2024: 4:13:02
  - Created BaseCounter prefab and made all counters variants
  - Refactored logic for counters into base counter for all shared functions and properties
  - Created ContainerCounter as counter variant with spawn kitchen object function and animation
  - updated selected counter visual to use BaseCounter as reference and to use a GameObject array for all the objects that make up counters so they all can turn a different material when selected
