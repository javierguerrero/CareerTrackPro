# CareerTrack Pro - Software Guidebook

## Introduction

![](https://drive.google.com/uc?id=1WkzdFAeVOG7KocJSl7oOvSkv6YS9TxXa_)

## Context

### Users

### External Systems

## Functional Overview

### Administrator

Seguridad

- Inicio de sesión
- Cerrar sesión
- Cambiar contraseña

Mantenimiento Alumno

- Agregar alumno
- Actualizar alumno
- Obtener alumno
- Eliminar alumno

Mantenimiento Empresas

- Agregar empresa
- Actualizar empresa
- Finalizar empresa
- Eliminar empresa
- Agregar empresa
- Actualizar empresa
- Eliminar empresa

## Authenticated User

Seguridad

- Inicio de sesión
- Cerrar sesión
- Cambiar contraseña

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

Students Api

```
http://localhost:9020/swagger
```

5. Connect to a different port with SQL Server Management Studio. Connect using a different port using a comma

ms.sql.users.db

```
localhost,1417
```

ms.sql.students.db

```
localhost,1418
```

Nota: Es probable que las BDs no haya sido creadas. Por ejemplo, la BD Usuarios es importante para registrar y autentiar usuarios. Correr las Migrations desde el proyecto "ms.users" (Default project: ms.users.api)