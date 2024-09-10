# Use the .NET Core SDK image to build the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 as base


FROM mcr.microsoft.com/dotnet/sdk:8.0 as build
ARG BUILD_CONFIGURATION=Release

WORKDIR /src

# Copy the solution file and project files to the container
COPY ./NoteAPI.Clean.sln ./
COPY ./src/Core/NoteAPI.Domain/NoteAPI.Domain.csproj ./src/Core/NoteAPI.Domain/
COPY ./src/Core/NoteAPI.Application/NoteAPI.Application.csproj ./src/Core/NoteAPI.Application/

# Restore dependencies for the solution
RUN dotnet restore ./NoteAPI.Clean.sln


COPY . .
