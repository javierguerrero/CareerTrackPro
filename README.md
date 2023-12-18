# CareerTrack Pro - Software Guidebook

## Introduction

![](https://drive.google.com/uc?id=1WkzdFAeVOG7KocJSl7oOvSkv6YS9TxXa_)

## Context

### Users

### External Systems

## Functional Overview

### Administrator

Security Module

- Login
- Logout
- Change password

JobSeeker Module

- Update JobSeeker
- Get JobSeekers
- Delete JobSeeker

## Job Seeker

Security Module

- Register
- Login
- Logout






Mantenimiento Empresas

- Agregar empresa
- Actualizar empresa
- Finalizar empresa
- Eliminar empresa
- Agregar empresa
- Actualizar empresa
- Eliminar empresa


https://www.figma.com/file/0NCDjQfKfM1PCLkrDYVuWL/Escuela-de-M%C3%BAsica?type=design&node-id=0-1&mode=design&t=VXOFeb1Tfw8db5vj-0

## Quality Attributes

### Performance

### Security

### Browser compatibility

## Constraints

### Budget

## Principles

### Automated testing

### Configuration

## Software Architecture

### Containers

### Components

## Infrastructure Architecture

## Deployment

## Development

### Levantar entorno de desarrollo

1. Ingresar a la carpeta raíz del proyecto "CareerTrackPro"
2. Abrir consola y ejecutar comando "docker-compose" para el despliegue de contenedores en Docker

```
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```

3. Ejecutar aplicaciones cliente:

Admin Dashboard (web)

```
http://localhost:4300/
```

Alumnnos (SPA)

```
http://localhost:4200/
```

4. Consultar APIs:

Users Authentication Api

```
http://localhost:9010/swagger
```

JobSeekers Api

```
http://localhost:9020/swagger
```

5. Connect to a different port with SQL Server Management Studio. Connect using a different port using a comma

ms.sql.users.db

```
localhost,1417
```

ms.sql.jobseekers.db

```
localhost,1418
```

Notas: 
* Es probable que las BDs no haya sido creadas. Por ejemplo, la BD Usuarios es importante para registrar y autentiar usuarios. Correr las Migrations desde el proyecto "ms.users" (Default project: ms.users.api).
* La tabla "jobseekers" tiene el campo "UserName" para que tenga una relación con el usuario del microservicio de autenticación.
* Todo se origina desde el manejador de creación de JobSeekers, del microservicio JobSeekers, CreateJobSeekerCommandHandler, de la capa de aplicación, donde tras la satisfactoria creación del JobSeeker en la base de datos de SQL Server, queremos crearle al JobSeeker un usuario en el microservicio de usuarios, publicando para ello el evento que se almacenará en la cola JobSeekerCreatedEvent, donde posteriormente el consumidor de usuarios interpretará el evento encolado.

