# MyCompany.MyApp

A .NET 10.0 C# console application.

## Build and Test

```bash
dotnet build
dotnet run
```

## Code Style

- C# 14 with nullable reference types enabled (`<Nullable>enable</Nullable>`)
- Implicit global usings enabled (`<ImplicitUsings>enable</ImplicitUsings>`)
- Target framework: `net10.0`

## Architecture

Single-file entry point (`Program.cs`) using top-level statements.

## Conventions

- Keep top-level statements in `Program.cs` for the entry point
- Prefer .NET BCL types and avoid third-party dependencies unless necessary

## References

- For C# and .NET questions, consult [Microsoft Learn](https://learn.microsoft.com/dotnet/) using the available Microsoft Learn tools
- For Humanizer library questions, consult the [Humanizer GitHub repository](https://github.com/Humanizr/Humanizer) using the available DeepWiki MCP tool (`deepwiki` `ask_question`)
