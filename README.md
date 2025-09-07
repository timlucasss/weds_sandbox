# NHS MPI PDQ Sandbox Patient Search

A **Blazor WebAssembly** project for testing patient searches against a **local API** that simulates the **NHS Wales MPI PDQ sandbox**. It parses HL7 XML responses and displays mock patient data safely for development purposes.

## Overview

Search for patients using:

- NHS Number  
- Name (Surname / Forename)  
- Date of Birth  
- Sex  
- Postcode  
- Case Number  
- Letter Reference Number  

The form sends data to a **local API** (`/api/patientdemographics`) which can proxy the sandbox. Responses are parsed and shown in a table.

> ⚠️ Development/testing only — no real patient data is used.

## Features

- Search form with validation  
- Day/Month/Year date input  
- Safe sandbox API integration  
- HL7 XML response parsing  
- Table results display  
- Clear form functionality  

## Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)  
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or VS Code with Blazor support  
- Local API endpoint for MPI PDQ sandbox (`http://localhost:5175/api/patientdemographics`)  
