using System;
using System.Collections.Generic;
using System.Text;

// TODO 1: Declarar el File-Scoped Namespace para la capa lógica de negocio 

    namespace CineIPVG.Core;
    internal class Producto
    {
    private decimal precioBase;

    public string Codigo { get; set; }
    public string Nombre { get; set; }

    // TODO 2: Propiedad Completa 'PrecioBase' (Validación: <= 0m asigna $1.000m por defecto)
    public decimal PrecioBase
    {
        get { return precioBase; }
        set
        {
            // TODO: Escribir la validación del setter
            if (value <= 0m)
                precioBase = 1000m;
            else
            precioBase = value;
        }
    }

    public Producto(string codigo, string nombre, decimal precioBase)
    {
        Codigo = codigo;
        Nombre = nombre;
        PrecioBase = precioBase;
    }

    // TODO 3: Declarar método virtual 'CalcularPrecioFinal()'
    public virtual decimal CalcularPrecioFinal()
    {
        return PrecioBase;
    }

    // TODO 4: Declarar método virtual 'ObtenerDetalle()'
    // que entrege un string con el detalle del producto y su precio final
    public virtual string ObtenerDetalle()
    {
        
    }
}

