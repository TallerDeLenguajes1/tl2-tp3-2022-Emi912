using System.Collections.Generic;

public class Cliente : Persona
{
    public string ReferenciaDireccion { get; set; }

    public Cliente(string nombre, string direccion, string telefono, string referenciaDireccion)
    {
        this.Id = HelperArchivos.GetLastIdCliente();
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.Telefono = telefono;
        this.ReferenciaDireccion = referenciaDireccion;
    }
}