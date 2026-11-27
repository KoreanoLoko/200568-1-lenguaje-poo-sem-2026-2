# Monitoreo Fundo IPVG — ejemplo de manejo de excepciones

**Fuentes:** cinco adjuntos recibidos, identificados por el estudiante como procedentes de MonitoreoFundoIPVG.zip. No se recibió el ZIP original ni un enunciado/rúbrica independiente. Se preserva el ejemplo sin cambios funcionales.

## Archivos

[Ejemplo recibido](ejemplo_recibido/): LecturaInvalidaException.cs, SensorAmbiental.cs, Program.cs (adjunto Program(9).cs), MonitoreoFundoIPVG.csproj y MonitoreoFundoIPVG.slnx. Proyecto SDK .NET 10, Exe, ImplicitUsings y Nullable habilitados. La solución referencia el proyecto del mismo directorio.

- [Análisis de código y 12 TODO](analisis_codigo.md).
- [Casos de prueba esperados](casos_prueba.md).
- [Presentación de 14 diapositivas](../../clases/manejo_de_excepciones_en_dotnet.md).
- [Apunte 32](../../apuntes/32_manejo_excepciones_try_catch_finally.md) y [apunte 33](../../apuntes/33_excepciones_personalizadas_throw_y_trazas.md).

## Arquitectura

```text
MonitoreoFundo.Core
  LecturaInvalidaException : Exception
  SensorAmbiental
MonitoreoFundo.App
  Program
    List<SensorAmbiental> (3 sensores)
    do-while + switch
    try / catch / finally
```

Las 12 tareas muestran código implementado en el adjunto. La revisión es estática; no se ejecutó dotnet build ni pruebas reales. No es una solución creada por el asistente. Los rangos son condiciones del ejercicio. Se normalizan nombres de Program y codificación/finales de línea sin alterar lógica.
