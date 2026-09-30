# Rúbrica Certamen 1

Rúbrica asociada al caso **Sistema de Préstamos de Notebooks Sede IPVG**.

## Puntaje total

```text
100 puntos
```

## 1. Sintaxis y Estructura BÁSICA C# / .NET — 15 pts

### Se excede — 15 pts

- Crea el proyecto con dotnet CLI.
- Compila sin advertencias ni errores.
- Define correctamente el namespace.
- Utiliza `decimal` para todos los montos monetarios.

### Dominio — 11 pts

- Compila correctamente.
- Presenta un error menor de convención de nombres o utiliza `double`/`float` en vez de `decimal`.

### Cerca — 8 pts

- Presenta errores menores de compilación corregibles.
- Demuestra manejo básico de tipos primitivos.

### Sin evidencia — 0 pts

- Errores graves de sintaxis.
- No demuestra dominio de tipos de datos en C#.

---

## 2. Encapsulación y Miembros de Clase — 20 pts

### Se excede — 20 pts

- Propiedades autoimplementadas con `get; private set;`.
- Campos privados para miembros estáticos de control global.

### Dominio — 15 pts

- Miembros estáticos y de instancia correctamente declarados.
- Alguna propiedad conserva un `public set` no justificado.

### Cerca — 10 pts

- Confunde miembros de instancia con `static`.
- O no utiliza `private set`.

### Debajo — 0 pts

- Declara atributos públicos sin propiedades.
- Omite principios básicos de encapsulación.

---

## 3. Sobrecarga de Constructores — 20 pts

### Se excede — 20 pts

- Implementa al menos dos constructores con firmas distintas.
- Uno básico.
- Otro con retraso inicial.
- Inicializa el estado consistentemente.

### Dominio — 15 pts

- Implementa ambos constructores.
- Existe redundancia o una inconsistencia menor en la inicialización.

### Cerca — 10 pts

- Solo implementa un constructor.
- O las firmas requieren ajustes.

### Debajo — 0 pts

- No implementa constructores válidos.

> **Nota de fidelidad:** la rúbrica utiliza `EstaDevuelto` como ejemplo de posible estado olvidado, aunque esa propiedad no figura en el enunciado suministrado.

---

## 4. Paso de Parámetros Avanzados (ref / out) — 25 pts

### Se excede — 25 pts

- Firma e invoca `ProcesarDevolucion`.
- Usa `ref` para modificar el stock físico del llamador.
- Usa `out` para la multa.
- Asigna el parámetro `out` en todos los caminos.

### Dominio — 19 pts

- Utiliza correctamente `ref` y `out`.
- Presenta un error menor en cálculo de multa o actualización de stock.

### Cerca — 13 pts

- Utiliza solo uno de los modificadores correctamente.
- Omite asignación obligatoria de `out` en alguna rama.
- Confunde referencia con paso por valor.

### Debajo — 0 pts

- No utiliza `ref` ni `out`.
- Firma incompatible con el requisito.

> **Nota de fidelidad:** la rúbrica menciona “multa por días de exceso”, mientras que el enunciado establece $120.00 por cada **minuto** de retraso.

---

## 5. Menú Interactivo y Control de Flujo — 20 pts

### Se excede — 20 pts

- Menú con `do-while`.
- Selección mediante `switch`.
- Ejecución fluida.
- Captura opciones.
- Muestra reportes estáticos claros.

### Dominio — 15 pts

- Implementa `do-while` y `switch`.
- Presenta pequeñas deficiencias de navegación.

### Cerca — 10 pts

- Utiliza `if-else` en vez de `switch`.
- O el bucle termina prematuramente.

### Debajo — 0 pts

- Código secuencial sin menú.
- O ciclo infinito que bloquea la consola.

## Distribución del puntaje

| Criterio | Puntaje |
| --- | ---: |
| Sintaxis y estructura C# / .NET | 15 |
| Encapsulación y miembros de clase | 20 |
| Sobrecarga de constructores | 20 |
| Paso de parámetros `ref` / `out` | 25 |
| Menú interactivo y control de flujo | 20 |
| **Total** | **100** |
