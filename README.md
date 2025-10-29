# 📚 Sistema de Gestión de Estudiantes y Cursos

Este proyecto consiste en el desarrollo de una API REST utilizando arquitectura por capas, Entity Framework Core y MySQL, para gestionar estudiantes, cursos e inscripciones en una institución educativa.

## 🎯 Objetivo General

Desarrollar una solución limpia y escalable que permita:

- Registrar y administrar estudiantes y cursos.
- Asignar estudiantes a cursos mediante inscripciones.
- Consultar inscripciones por estudiante o por curso.

## 🧱 Arquitectura del Proyecto

La solución está dividida en los siguientes proyectos:

- **webEscuela.Api**: Contiene los controladores, configuración de servicios y endpoints.
- **webEscuela.Application**: Lógica de negocio y servicios de aplicación.
- **webEscuela.Domain**: Entidades y contratos (interfaces) del dominio.
- **webEscuela.Infrastructure**: Contexto de base de datos, configuración de EF Core y repositorios.

## 🛠️ Tecnologías Utilizadas

- ASP.NET Core
- Entity Framework Core
- MySQL
- Inyección de dependencias
- Postman (para pruebas de endpoints)

## 🗃️ Estructura de Capas

- **Domain**: Define las entidades `Estudiante`, `Curso` e `Inscripcion`, y sus relaciones.
- **Infrastructure**: Implementa el `DbContext`, repositorios y configuración de migraciones.
- **Application**: Contiene los servicios para manejar la lógica de negocio.
- **API**: Expone los endpoints para interactuar con el sistema.

## 📌 Funcionalidades

### Estudiantes
- Registrar un nuevo estudiante.
- Listar todos los estudiantes.
- Obtener un estudiante por ID.
- Actualizar información de un estudiante.
- Eliminar un estudiante.

### Cursos
- Crear un nuevo curso.
- Listar todos los cursos.
- Obtener un curso por ID.
- Actualizar información de un curso.
- Eliminar un curso.

### Inscripciones
- Registrar una inscripción (asignar estudiante a curso).
- Listar todas las inscripciones.
- Consultar cursos inscritos por estudiante.
- Consultar estudiantes inscritos en un curso.

## 🔗 Relaciones

- Un estudiante puede estar inscrito en varios cursos.
- Un curso puede tener varios estudiantes inscritos.
- La relación se gestiona mediante la entidad intermedia `Inscripcion`.

## 🚀 Cómo Ejecutar

1. Clonar el repositorio.
2. Configurar la cadena de conexión a MySQL en `appsettings.json`.
3. Ejecutar las migraciones con EF Core.
4. Levantar el proyecto `webEscuela.Api`.
5. Probar los endpoints con Postman.

---

Desarrollado como parte del taller de arquitectura limpia y desarrollo de APIs con .NET.
