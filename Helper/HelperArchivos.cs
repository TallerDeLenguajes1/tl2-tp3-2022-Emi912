using System;
using System.Collections.Generic;
using System.IO;

public static class HelperArchivos
{
    public static void UpdateFile(string path, string text){
        
    }

    public static List<Cadete> GetAllCadetes(){
        string path = @"C:\Users\Emilio\Desktop\Emilio\Taller de Lenguajes II\tl2-tp3-2022-Emi912\csv\empleados.csv";
        List<Cadete> cadetes = new List<Cadete>();
        if (File.Exists(path))
        {
            StreamReader reader = new StreamReader(path);
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                string[] fila = linea.Split(';');
                Cadete nCadete = new Cadete(Convert.ToInt32(fila[0]), fila[1], fila[2], fila[3]);
                cadetes.Add(nCadete);
            }
        }else{
            Console.WriteLine("No existe la ubicacion dela archivo");
        }

        return cadetes;
    }


    public static Cadeteria GetCadeteria(){
         string path = @"C:\Users\Emilio\Desktop\Emilio\Taller de Lenguajes II\tl2-tp3-2022-Emi912\csv\cadeteria.csv";
        Cadeteria cadeteria;
        if (File.Exists(path))
        {
            StreamReader reader = new StreamReader(path);
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                string[] fila = linea.Split(';');
                cadeteria = new Cadeteria(fila[0], fila[1]);
                cadeteria.ListadoCadetes = HelperArchivos.GetAllCadetes();
                return cadeteria;

            }
        }else{
            Console.WriteLine("No existe la ubicacion dela archivo");
        }
        return null;
    }

    public static int GetLastIdCliente(){
        string path = @"C:\Users\Emilio\Desktop\Emilio\Taller de Lenguajes II\tl2-tp3-2022-Emi912\csv\clientes.csv";
        string[] fila = null;
        if (File.Exists(path))
        {
            StreamReader reader = new StreamReader(path);
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                fila = linea.Split(';');
            }
            reader.Close();
        }else{
            Console.WriteLine("No existe la ubicacion dela archivo");
        }
        if (fila[0] == null)
        {
            return 1;
        }else{
        return Convert.ToInt32(fila[0]);

        }
    }

    public static bool InsertPedido(Pedido nPedido){
        try
        {
        string path = @"C:\Users\Emilio\Desktop\Emilio\Taller de Lenguajes II\tl2-tp3-2022-Emi912\csv\pedidos.csv";
        StreamWriter wrt = new StreamWriter(path);
        wrt.WriteLine($"{nPedido.Nro};{nPedido.Observacion};{nPedido.Cliente};{nPedido.Estado}");
        wrt.Close();
        return true;
        }
        catch (System.Exception)
        {
            return false;
            throw;
        }
    }

    public static bool InsertCliente(Cliente nCliente)
    {
        try
        {
            string path = @"C:\Users\Emilio\Desktop\Emilio\Taller de Lenguajes II\tl2-tp3-2022-Emi912\csv\clientes.csv";
            StreamWriter wrt = new StreamWriter(path);
            wrt.WriteLine($"{nCliente.Id};{nCliente.Nombre};{nCliente.Direccion};{nCliente.Telefono}");
            wrt.Close();
            return true;
        }
        catch (System.Exception)
        {
            return false;
            throw;
        }
    }

    public static int GetLastPedido(){
        string path = @"C:\Users\Emilio\Desktop\Emilio\Taller de Lenguajes II\tl2-tp3-2022-Emi912\csv\pedidos.csv";
        string[] fila = null;
        if (File.Exists(path))
        {
            StreamReader reader = new StreamReader(path);
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                fila = linea.Split(';');
            }
            reader.Close();
        }else{
            Console.WriteLine("No existe la ubicacion dela archivo");
        }
        if (fila == null)
        {
            return 1;
        }else{
        return Convert.ToInt32(fila[0]);

        }
    }
}