# Build instructions


## Build from source

### Prerequisites

- dotnet sdk 8.0 or later
- swig 4.3.0 or later, use `scoop install swig` to install swig on windows, do not use `winget`.
- cmake 3.31.3 or later.

### Build

1. Clone the repository and open the solution file `EsunnyTap.sln` with Visual Studio 2022.
2. run the command in `EsunnyTapApi/SwigGenerator.sh` to generate the cpp and C# wrapper code.
3. run `win-build.sh` for windows native build or `linux-build.sh` for linux native build.
4. Build the `EsunnyTap.Net` C# project.