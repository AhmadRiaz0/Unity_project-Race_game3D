# Unity_project-Race_game3D
Study project for engineering degree Race Game 3D

Study project for engineering degree Game 3D

Script C#

Project : 3D racing game with 2 laps of the circuit, as fast as possible, with various moving obstacles on the track.

Setting up the different scenes of the project: Scene 0 : MainMenu : Main menu (C# : MainMenu) Button: Play Button: Quit Scene 1: RaceArea01: Game circuit (C#: SceneLoader) to switch to the FinishMenu once the player has completed 2 rounds. Scene 2: FinishMenu: End menu (C#: Finish) Text: Main Text: First turn completed Time of first turn Text Second turn completed Time of second lap Button: Try Again Button: Quit

Terrain: Set up of 3 main textures representing the different elements of the terrain: General terrain: Texture: Grass A road: Texture: Asphalt Addition of elements at the ends of the road: Rock texture

Setting up the different types of trees Set up 4 cylinders (Obstacle to go around) Installation of 2 ramps (Jump) Placement of a plane (Ground surface) Set up 3 cubes ("Step down from plane") Set up a structure assembled with 34 cubes. 10 cylinders representing moving obstacles.

Car: Set up the player's RallyCar from the Asset Store with : RCK (C#: VehiculeControl) (C#: VehiculeDamage)

Camera : MainCamera : (C# : CameraStable) Set up a cube above the car to hold the camera. This guarantees the camera's stability. Mini camera: (Canva > MiniMapObject) Add a second camera to provide a different view of the route.

Games : FinishLine Trigger (C#: LapComplete) (C#: HalfPointTrigger): Set the start (LapCompleteTrigger) and middle (HalfPointTrigger) triggers of the field. When the middle trigger comes into contact with the car, it disappears and causes the start trigger to appear, and vice versa. Stopwatch (top right of screen): (C#: LapTimeManager) : UI/Panel : UI/Text "MinDisplay" : Minute UI/Text "SecDisplay": Second UI/Text "MiliDisplay": Millisecond Best Time (top right of screen): (C#: LapComplete) : UI/Panel : UI/Text "MinDisplayBest" : Minute UI/Text "SecDisplayBest": Second UI/Text "MiliDisplayBest" : Millisecond Number of laps to complete: 2 (top left of screen) : (C# : LapComplete) When the variable LapsDone = 2, then we're sent to the FinishMenu scene with the time of the 2 laps completed.

AI : WayPoint (C#: Waypoint): Add WayPoints to draw the various points through which obstacles must pass. Obstacle in motion (C#: ObstacleMovement): reverses the direction of obstacles in relation to the car, so that they can rotate around the circuit indefinitely, creating obstacles in motion that arrive in front of the car and which the car must avoid to achieve the best possible lap time.
