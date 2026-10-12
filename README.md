# UserProfileApp

## Objective
The objective of this project is to demonstrate basic Git version control and collaboration workflow by developing a simple C# console application that represents and displays a user profile.

## Technologies Used
* **C#**
* **.NET 10**
* **Git**
* **GitHub**
* **Visual Studio Code**

## How to Run the Project

### Prerequisites
* **.NET 10 SDK** (or a compatible SDK for the project's target framework)
* **Git**

### Steps
1. **Clone or download** this repository.
2. **Open a terminal** in the repository's root directory.
3. **Navigate** to the application folder:
   ```bash
   cd UserProfileApp
   ```
4. **Run** the application:
   ```bash
   dotnet run
   ```

> 💡 **Tip:** To build the project without running it, use:
> ```bash
> dotnet build
> ```

## Git Workflow Used
The project follows a **feature-branch workflow**:
* `main` — The initial and stable branch.
* `develop` — The development and integration branch.
* `feature/user-profile` — The branch used to implement the user profile feature.

### Steps Performed
1. Initialized a new Git repository.
2. Added a README file and a .NET-compatible `.gitignore` file.
3. Created the `develop` branch from `main`.
4. Created the `feature/user-profile` branch from `develop`.
5. Implemented the user profile model and console output.
6. Made at least three meaningful commits with descriptive messages.
7. Opened a pull request from `feature/user-profile` into `develop`.
8. Documented the changes and testing procedure in the pull request.
9. Reviewed and merged the feature branch into `develop`.

## Verification and Testing
The application can be checked using:
* `dotnet build` — Verifies that the project compiles cleanly.
* `dotnet run` — Verifies that the application executes and correctly displays the user profile.
* `git status` and `git log` — Inspects the working tree and commit history.

## Project Structure
```text
├── .gitignore                      # Files excluded from Git tracking
├── README.md                       # Project overview and instructions
└── UserProfileApp/
    ├── Program.cs                  # Application entry point
    ├── UserProfile.cs              # User profile model
    └── UserProfileApp.csproj       # Project configuration file
```
