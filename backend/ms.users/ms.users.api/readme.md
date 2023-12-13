## Comandos Docker

Listar las imágenes instaladas en el equipo
	docker image ls

Creacion contenedores
	docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=.123Pass456." -p 1433:1433 --name users.db -v /c/data/docker/musicschool/sqlserver/users:/var/opt/mssql/data -d mcr.microsoft.com/mssql/server:2022-latest

## Comandos EF

Add-Migration

Update-Database