using System;
using System.Collections.Generic;

public class Cadeteria
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<Cadete> ListadoCadetes { get; set; }

    public Cadeteria(string nombre, string direccion)
    {
        this.Nombre = nombre;
        this.Direccion = direccion;
    }

    public void ShowCadeteria(){
        Console.WriteLine(this.Nombre);
        Console.WriteLine(this.Direccion);
    }

    public void ShowCadetes(){
        Console.WriteLine($"Listadod de Empleados de {this.Nombre}");
        foreach (var item in ListadoCadetes)
        {
            item.ShowCadete();
        }
    }
}