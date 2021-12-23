# Shark Lyrics Generator
Generates lyrics in Baby Shark style

## Goal
To learn dependency injection

## Program
Generate 5 verses in the style of Baby Shark with different types of sharks

```
dotnet run

Baby Shark do-do-do-do-do-do
Baby Shark do-do-do-do-do-do
Baby Shark do-do-do-do-do-do
Baby Shark

Mummy Shark do-do-do-do-do-do
Mummy Shark do-do-do-do-do-do
...

You get the idea
```

## About
Written in C#
Uses Autofac for dependency injection

    .
    ├── .vscode
    ├── services                # The different services used in dependency injection
    │   ├── LyricsService.cs    # Generates the lyrics
    │   ├── OutputService.cs    # Formats output to the console
    │   └── SharkService        # Generates shark types (well, family member types)
    ├── Program.cs              # The entrypoint for the program
    └── README.md


## Getting Started
1. Clone the repository
2. Make sure you have the following installed:
    1. [dotnet sdk or runtime](https://dotnet.microsoft.com/en-us/download)
3. Restore the nuget packages
   `dotnet restore`
4. Run the program
   `dotnet run`

## Resources
[Autofac getting started guide](https://autofac.readthedocs.io/en/latest/getting-started/index.html)