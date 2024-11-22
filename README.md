Unity Unit Testing Example
This repository demonstrates how to implement Unit Tests in Unity using Edit Mode and Play Mode tests. The project includes an example game setup with a player unit that can move within predefined boundaries.

Features
Player Movement: The player unit can move up, down, left, and right within specified boundaries.
Directional Logic: Predefined direction vectors for consistent movement.
Boundary Management: Ensures the player does not move beyond allowed limits.
Unit Testing: Comprehensive tests for both Edit Mode and Play Mode scenarios.
Project Structure
Unity
├── Assets/
│ ├── Scripts/
│ │ ├── Boundaries.cs
│ │ ├── Direction.cs
│ │ ├── PlayerController.cs
│ │ └── Unit.cs
│ ├── Tests/
│ │ ├── Edit Mode/
│ │ │ └── DirectionTest.cs
│ │ └── Play Mode/
│ │   └── MoveTests.cs
Scripts Description
Boundaries.cs: Defines the upper, lower, left, and right boundaries of the game area.
Direction.cs: Specifies direction vectors (Up, Down, Left, Right) for movement.
PlayerController.cs: Handles player input for movement.
Unit.cs: Manages player movement and boundary checks.
Tests Description
Edit Mode: Validates the Direction class to ensure correct direction vectors.
Play Mode: Simulates and verifies player movement in the runtime environment.
Getting Started
Prerequisites
Unity 2021.3 or newer.
Basic understanding of Unity Editor and C# scripting.
Setup Instructions
Clone the repository:
git clone https://github.com/MCLakshan/Unit-Test-in-Unity-Example-EnvisionStudio-Blog.git
Open the project in Unity Editor.
Running Tests
Open the Test Runner:

Go to Window > General > Test Runner in Unity.
Run Edit Mode Tests:

Select the Tests > Edit Mode folder in the Test Runner.
Click Run All.
Run Play Mode Tests:

Switch to Play Mode in the Test Runner.
Select the Tests > Play Mode folder.
Click Run All.
Example Usage
Press W, A, S, or D keys to move the player unit in the respective direction.
The player will stop at the defined boundaries.
Key Concepts
Edit Mode Tests:
Used for isolated logic validation without requiring game runtime.
Play Mode Tests:
Used for runtime behavior validation, including GameObjects and MonoBehaviours.
License
This project is licensed under the MIT License. See the LICENSE file for details.

Happy coding!
