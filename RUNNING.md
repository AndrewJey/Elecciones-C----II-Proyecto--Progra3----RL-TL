

<!-- local-development:start -->
# Desarrollo local

Puedes abrir este repositorio en VS Code, Antigravity o Sublime Text. El compilador y los servicios necesarios dependen del componente indicado abajo.

## Visual Studio 2022 / .NET Framework

Instala la carga de trabajo de escritorio .NET y el paquete de destino indicado en la tabla. Los proyectos ASP.NET también requieren la carga web e IIS Express. Abre la solución `.sln` correspondiente y selecciona el proyecto de aplicación para iniciar.

```powershell
# Ejecutar desde Developer PowerShell de Visual Studio 2022
$solutionDir = (Resolve-Path 'ProyectoRaulTony').Path + '\'
MSBuild.exe 'ProyectoRaulTony/ProyectoRaulTony/ProyectoRaulTony.csproj' /restore /p:RestorePackagesConfig=true /p:Configuration=Debug /p:DeployOnBuild=false "/p:SolutionDir=$solutionDir"
```

## Componentes y validación

Inventario y compilaciones locales del 2026-11-15. Una compilación correcta no acredita todavía interacción, compatibilidad de base de datos, instalador ni despliegue.

| Componente | Tipo / destino | Validación |
| --- | --- | --- |
| [ProyectoRaulTony/ProyectoRaulTony.sln](<ProyectoRaulTony/ProyectoRaulTony.sln>) | solution | Sin ejecutar |
| [ProyectoRaulTony/ProyectoRaulTony/ProyectoRaulTony.csproj](<ProyectoRaulTony/ProyectoRaulTony/ProyectoRaulTony.csproj>) | dotnet / v4.8.1 | Compila; prueba funcional pendiente |

## Archivos ignorados

`.gitignore` excluye credenciales locales, estado del editor y salidas de las herramientas detectadas. No deja de versionar archivos que ya estaban en Git. Los manifiestos, archivos de bloqueo, recursos fuente y scripts de esquema forman parte del código.
<!-- local-development:end -->

<!-- improvements-20261119:start -->
## Mejoras y verificación — 2026-11-19 (Integridad de persistencia en archivos y validaciones de capa lógica)

- Corregida la corrupción de contraseñas en `VotantesCL.AgregarVotantes` (faltaba espacio antes del indicador `0`) y la coincidencia por subcadena `Contains(id)` en `Editar`/`Eliminar` que alteraba registros con IDs similares.
- Añadido soporte de directorio configurable (`ELECCIONES_DATA_DIR`), copia segura de imágenes sin bloqueo de archivo en `CandidatosCL`, y soporte para fechas cortas y formato legado en `PeriodoCL`.
- Validación: compilación MSBuild y 11 aserciones automatizadas de CRUD en votantes, periodos, votos y candidatos.
<!-- improvements-20261119:end -->
