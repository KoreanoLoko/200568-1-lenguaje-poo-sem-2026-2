# Pesquera Chan — análisis de plantillas y tareas

**Base:** seis adjuntos recibidos, sin un enunciado externo. Se documentan solo las instrucciones observables en los archivos, sin completar los TODO.

| TODO | Archivo | Trabajo solicitado y estado |
|---:|---|---|
| 1 | PezCultivo | File-scoped namespace PesqueraChan.Core; falta. |
| 2 | PezCultivo | Propiedad PesoKilos con piso 50.0m si value <= 50.0m; getter/setter presentes, falta regla. |
| 3 | PezCultivo | Método virtual CalcularValorComercial(), base $3.200/kg; falta. |
| 4 | PezCultivo | Método virtual ObtenerFicha(), código, especie y valor; falta. |
| 5 | LoteSalmon | Namespace Core; falta, así como herencia de PezCultivo señalada en comentario. |
| 6 | LoteSalmon | Constructor con base(...); falta. |
| 7 | LoteSalmon | Override de valoración; faltan cálculo y método; ficha override ya escrita. |
| 8 | LoteEspecieMarina | Namespace Core; falta, así como herencia de PezCultivo. |
| 9 | LoteEspecieMarina | Constructor con base(...); falta. |
| 10 | LoteEspecieMarina | Override de valoración; falta; ficha override ya escrita. |
| 11 | Program | using del Core y alias PezChan; faltan. |
| 12 | Program | ProcesarTasacion(PezChan lote, ref decimal patrimonioPesquera, out decimal bonificacionEspecial); falta. |
| 13 | Program | Declarar e instanciar List<PezChan>; cuatro llamadas Add ya presentes, lista no declarada. |
| 14 | Program | foreach y ObtenerFicha() en opción 3; falta. |
| 15 | Program | foreach y ProcesarTasacion con ref/out en opción 4; falta. |

## Clases y comportamiento

PezCultivo: pesoKilos privado, codigoLote y especie protegidos; constructor asigna los campos y usa la propiedad PesoKilos. El setter actual no limita el peso. No es abstracta en la plantilla.

LoteSalmon: TipoAgua (SALADA/DULCE), EsCertificadoASC bool. Base por kg 4.000m; si SALADA, añadir 150.000m; si ASC, multiplicar subtotal por 1.25m. El orden importa.

LoteEspecieMarina: TipoAlimentacion (ORGANICA/ESTANDAR), CantidadUnidades int. Base 3.000m/kg; si ORGANICA, multiplicar por 1.18m; si unidades > 500, añadir 100.000m.

## Programa

El menú do-while + switch contiene cinco opciones: agregar salmón, agregar especie marina, mostrar fichas y Count, tasar y mostrar arqueo, salir. Opciones 1 y 2 añaden objetos fijos (SAL-103 y PEC-203); no leen sus campos desde consola. Hay cuatro objetos precargados. patrimonioTotalPesquera se inicializa fuera del ciclo; totalTasacion se inicializa en cada ejecución de la opción 4. No hay implementación de ProcesarTasacion ni se especifica en la plantilla una fórmula para bonificacionEspecial, tipo de retorno o política de acumulaciones repetidas: no se inventan esos requisitos.

## Bloqueos observables

Las subclases declaran override sin heredar de PezCultivo, faltan los métodos virtuales, constructores y biomasaTotal, y el peso no se valida aún. Son problemas de código incompleto, no fallos de una solución final. No se ejecutó compilación. El proyecto permite estudiar [namespaces y alias](../../apuntes/24_namespaces_using_alias_tipos.md), [ref/out](../../apuntes/18_parametros_valor_ref_out.md) y [polimorfismo](../../apuntes/30_polimorfismo_despacho_dinamico_sobrecarga_override.md).
