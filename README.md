# CareerTrackPro - Software Guidebook

## Introduction

This software guidebook provides an overview of the CareerTrackPro website. It includes a
summary of the following:

1. The requirements, constraints and principles behind the website.
2. The software architecture, including the high-level technology choices and structure of
   the software.
3. The infrastructure architecture and how the software is deployed.
4. Operational and support aspects of the website.

## Context

The CareerTrackPro website allows you to keep track of all your applications so you can easily follow up and stay organized.

![](https://drive.google.com/uc?id=1WkzdFAeVOG7KocJSl7oOvSkv6YS9TxXa_)

### Users

1. JobSeeker: Authenticated users that keep track of all their applications.
2. Admin: People with administrative (super-user) access to the website can manage jobseekers and content that is aggregated into the website.

### External Systems

1. E-Mail System: The SMTP server for Gmail is a free SMTP server that anyone across the globe can use. It allows you to manage email transactions from your Gmail account via email clients or web applications. [More info](https://www.siteground.com/kb/gmail-smtp-server/)

## Functional Overview

This section provides a summary of the functionality provided by the CareerTrackPro website. We are going to focus on a technique called "Example Mapping" that is a simple and efficent way to facilitate your requirement workshops. [More info](https://blog.nicopaez.com/2023/04/05/introduccion-al-mapeo-de-ejemplos-example-mapping/)

### JobSeeker

```
User Story: Register user
    As a JobSeeker
    I want to register on the CareerTrackPro website
    So that I can keep track of all my applications

Rule: Register user with required fields username, password, firstname, lastname and email
    Example: Complete required fields
        * Javier chooses "register"
        * Enters required fields username('jguerrero'), password('******'), firstname('Javier'), lastname('Guerrero') and email('jguerrero@demo.com')
        * Save data
        * Successful registration
    Example: Do not complete required fields
        * Javier chooses "Register"
        * Enters required fields username('jguerrero'), password('******')
        * Save data
        * Error msg. Please complete all required fields
Rule: Only valid password is accepted
    Example: Valid password entered
        * Javier enters a valid password('P@ssw0rd')
        * Save data
        * Sucessfull registration
    Example: Invalid password entered
        * Javier enters an invalid password('demo')
        * Save data
        * Error msg. Invalid password
```

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

### Admin

Security Module

- Login
- Logout
- Change password

JobSeeker Module

- Update JobSeeker
- Get JobSeekers
- Delete JobSeeker

https://www.figma.com/file/0NCDjQfKfM1PCLkrDYVuWL/Escuela-de-M%C3%BAsica?type=design&node-id=0-1&mode=design&t=VXOFeb1Tfw8db5vj-0

## Quality Attributes

### Performance

All pages on BirthdayApp should load and render in under five seconds, for fifty concurrent users.

### Security

All authentication must be done via a third-party mechanism such as Twitter, Facebook or Google.

### Browser compatibility

The CareerTrackPro website should work consistently across the following browsers:

- Chrome
- Edge
- Firefox

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

- Es probable que las BDs no haya sido creadas. Correr las Migrations para los proyectos "ms.users" (Startup project: ms.users.api - Default project: ms.users.infrastructure) y ms.jobseekers (Startup project: ms.jobseekers.api - Default project: ms.jobseekers.infrastructure).
- La tabla "jobseekers" tiene el campo "UserName" para que tenga una relación con el usuario del microservicio de autenticación.
- Todo se origina desde el manejador de creación de JobSeekers, del microservicio JobSeekers, CreateJobSeekerCommandHandler, de la capa de aplicación, donde tras la satisfactoria creación del JobSeeker en la base de datos de SQL Server, queremos crearle al JobSeeker un usuario en el microservicio de usuarios, publicando para ello el evento que se almacenará en la cola JobSeekerCreatedEvent, donde posteriormente el consumidor de usuarios interpretará el evento encolado.
