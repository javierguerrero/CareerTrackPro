# MusicSchool - Software Guidebook

## Introduction

![](https://drive.google.com/uc?id=1WkzdFAeVOG7KocJSl7oOvSkv6YS9TxXa)

## Context

### Users

### External Systems

## Functional Overview

Seguridad

- Inicio de sesión
- Cerrar sesión
- Cambiar contraseña

Mantenimiento Alumno

- Agregar alumno
- Actualizar alumno
- Obtener alumno
- Eliminar alumno

Mantenimiento Ciclo

- Agregar ciclo
- Actualizar ciclo
- Finalizar ciclo
- Eliminar ciclo

Mantenimiento Clase

- Agregar clase
- Actualizar clase
- Eliminar clase

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
1. Ingresar a la carpeta raíz del proyecto "MusicSchool"
2. Abrir consola y ejecutar comando "docker-compose" para el despliegue de contenedores en Docker

```
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```

3. Ejecutar aplicaciones cliente:

Dashboard (web)
```
http://localhost:4300/
```

Alumnnos (SPA)
```
http://localhost:4200/
```

4. Consultar las APIs:

ms.users.api
```
http://localhost:9010/swagger
```

ms.students.api
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

