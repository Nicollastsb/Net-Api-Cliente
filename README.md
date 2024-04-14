# Net-Api-Cliente

## Installation

1. Clone the repository.
2. Install Docker.
3. Visual Studio 2022
4. .Net 8.0 SDK

## Development server

1. Check docker with "docker info"
2. If Docker is running, run this command "docker run -it -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=A&VeryComplex123Password" -p 1433:1433 --name sql-server-2022 mcr.microsoft.com/mssql/server:2022-latest
3. Start the container with "docker start -i sql-server-2022"
4. Run as https.
5. Run the angular front-end project "https://github.com/Nicollastsb/Angular-Api-Cliente"
