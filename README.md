# LeetCode Practice Hub

## Overview
This repository tracks daily LeetCode solving progress using small, focused C# implementations. The goal is to iterate quickly on ideas, verify them with lightweight console tests, and record insights for future reference.

## Highlights
- ✅ Clean, single-class problem implementations in `LeetCodeSample.cs`
- ✅ Console-style regression tests inside `Program.cs` for rapid validation
- ✅ Scenario-based test helpers covering edge cases and official examples

## Project Layout
- `LeetCodeSample.cs` – Core problem solutions grouped by region
- `Program.cs` – Console harness with toggleable test regions
- `.gitignore` – Standard .NET and Visual Studio exclusions

## Getting Started
```powershell
dotnet restore
dotnet run
```

All command examples assume Windows PowerShell in the repository root.

## Testing Strategy
Enable the desired `#region` blocks in `Program.cs`, run the target scenario, and review the colored console output for pass/fail feedback. This approach keeps feedback fast without relying on a heavyweight test framework.

## Roadmap
- Expand reusable helpers for common array/string patterns
- Add benchmarks for performance-sensitive solutions
- Introduce optional xUnit tests alongside console checks