# Use the .NET Core SDK image to build the application
FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build-env

# Set the working directory inside the container
WORKDIR /app

# Copy the solution file and project files to the container
COPY ./NoteAPI.Clean.sln ./
COPY ./src/Core/NoteAPI.Domain/NoteAPI.Domain.csproj ./src/Core/NoteAPI.Domain/
COPY ./src/Core/NoteAPI.Application/NoteAPI.Application.csproj ./src/Core/NoteAPI.Application/

# Restore dependencies for the solution
RUN dotnet restore ./NoteAPI.Clean.sln

RUN dotnet buil