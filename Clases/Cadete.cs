using System;
using System.Collections.Generic;

public class Cadete : Persona
{
    public List<Pedido> ListadoPedidos { get; set; }

    public Cadete(int id, string nombre, string direccion, string telefono)
    {
        this.Id = id;
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.Telefono = telefono;
    }
    
    public void ShowCadete(){
        Console.WriteLine(this.Id);
        Console.WriteLine(this.Nombre);
        Console.WriteLine(this.Direccion);
        Console.WriteLine(this.Telefono);

    }
}