# 032 Swagger

## Lecture

NO YOUTUBE VIDEO
[![# Swagger](https://img.youtube.com/vi/wYPpizfjVX8/0.jpg)](https://www.youtube.com/watch?v=wYPpizfjVX8)

## Instructions

In `HomeEnergyApi/Program.cs`
- Call the following methods on `builder.Services`
    - `AddVersionedApiExplorer()` with the following passed options
        - `GroupNameFormat` as `'v'VVV`
        - `SubstituteApiVersionInUrl` as `true`
    - `AddSwaggerGen()` with the following passed options
        -

## Additional Information
- Do not remove or modify anything in `HomeEnergyApi.Tests`
- Some Models may have changed for this lesson from the last, as always all code in the lesson repository is available to view
- Along with `using` statements being added, any packages needed for the assignment have been pre-installed for you, however in the future you may need to add these yourself

## Building toward CSTA Standards:
- Document design decisions using text, graphics, presentations, and/or demonstrations in the development of complex programs (3A-AP-23) https://www.csteachers.org/page/standards
- Systematically design and develop programs for broad audiences by incorporating feedback from users (3A-AP-19) https://www.csteachers.org/page/standards

## Resources
- https://swagger.io/
- https://github.com/dotnet/aspnet-api-versioning/wiki/API-Documentation

Copyright &copy; 2025 Knight Moves. All Rights Reserved.
