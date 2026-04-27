<!-- By Douglas Barbosa -->

# CodeChallengesLab

CodeChallengesLab is a .NET 8 repository for practicing coding challenges using C#, xUnit, and Test-Driven Development.

The goal is not only to solve algorithm problems, but also to demonstrate clean code, separation of concerns, testability, and maintainable project organization.

## Current Scope

- Beecrowd problems
- LeetCode problems
- xUnit tests
- Fake input/output for console-based challenges
- GitHub Actions CI

## Project Structure

```text
CodeChallengesLab/
├── CodeChallengesLab/                    # Production project
│   ├── Beecrowd/
│   │   ├── Application/
│   │   ├── Domain/
│   │   │   ├── IO/
│   │   │   ├── Problems/
│   │   │   └── Services/
│   │   └── Infrastructure/
│   ├── LeetCode/
│   ├── Program.cs
│   └── CodeChallengesLab.csproj
├── CodeChallengesLab.Tests/              # Test project
│   ├── Beecrowd/
│   │   ├── Application/
│   │   └── Domain/
│   │       ├── IO/
│   │       ├── Problems/
│   │       └── Services/
│   ├── LeetCode/
│   └── CodeChallengesLab.Tests.csproj
├── .github/workflows/ci.yml
├── CodeChallengesLab.sln
└── README.md
```

## Technology Stack

- .NET 8
- C#
- xUnit
- GitHub Actions
- Test-Driven Development
- Object-Oriented Programming
- SOLID principles

## Testing Strategy

The test project mirrors the production structure.

For Beecrowd problems, tests usually validate:

- input reading
- problem execution
- expected output

Console input and output are abstracted through:

- `IInput`
- `IOutput`

The test project provides:

- `FakeInput`
- `FakeOutput`

This allows deterministic tests without using the real console.

## Running the Project

From the repository root:

```bash
dotnet restore
dotnet build
dotnet test
```

To run the console project:

```bash
dotnet run --project CodeChallengesLab/CodeChallengesLab.csproj
```

## Example

Beecrowd Problem 1004 receives two integer values and prints their product.

Input:

```text
3
9
```

Expected output:

```text
PROD = 27
```

This is tested using fake input and fake output.

## CI

The repository uses GitHub Actions to restore, build, test, and collect coverage on every push to `main` and on pull requests.

Recommended workflow steps:

```yaml
- name: Restore dependencies
  run: dotnet restore CodeChallengesLab.sln

- name: Build
  run: dotnet build CodeChallengesLab.sln --configuration Release --no-restore

- name: Run Tests with Coverage
  run: dotnet test CodeChallengesLab.sln --configuration Release --no-build --logger "console;verbosity=normal" --collect:"XPlat Code Coverage"
```

## Roadmap

- Add more Beecrowd problems
- Add more LeetCode problems
- Add HackerRank folder
- Improve command-line problem selection
- Add coverage badge
- Add documentation per problem

## Purpose

This repository is part of a professional engineering portfolio focused on demonstrating practical software engineering skills through simple problems implemented with production-oriented practices.

##
### LINKS
- [:house: HOME](https://github.com/douglassbarbosa/Home)
- [🌐 douglasbarbosa.com](https://www.douglasbarbosa.com/)
- [💼 LinkedIn](https://www.linkedin.com/in/douglasbarbosadev)