# CMP205 Lab 09: Object Relational Mapping

Starter project for Lab 09. Follow the tasks in the lab sheet on MyLearningSpace.

## What is included

- `UniversityLabEF.sln`: a Windows Forms App (.NET 8)
- `Models/`: the `Person`, `Student` and `Department` classes from Week 6.
  `Department` now has a `DepartmentId` key, and `Student` has a constructor without parameters
- `Data/AppDbContext.cs`: the DbContext to complete in Task 1
- `SampleData.cs`: a `Seed` method, commented out until Task 3
- `Form1`: one tab per lab task, with all the controls you need.
  The buttons have no code yet: double-click a button in the designer to create its Click handler.
- NuGet packages, already referenced: `Microsoft.EntityFrameworkCore.SqlServer`,
  `Microsoft.EntityFrameworkCore.Tools` and `Microsoft.Extensions.Configuration.UserSecrets`

There is no SQL script this week: Entity Framework creates the tables with a migration.

## Getting started

1. Open `UniversityLabEF.sln` in Visual Studio and build it once, so the NuGet packages are restored.
2. Store your connection string with Manage User Secrets, as in Week 8.
   Never put your connection string or password in the code: this repository is on GitHub.
3. Commit and push your work at the end of each session.

## Use of generative AI

The starter code and this README were generated with Claude (Anthropic) from the module's
Week 6 class design, then reviewed and tested by the module tutor.
