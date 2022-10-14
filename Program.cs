using System;
using System.Collections.Generic;

namespace tl2_tp3_2022_Emi912
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jornada = true;
            do
            {
                Console.WriteLine("Escoga una operacion para realizar");
                int operacion = Convert.ToInt32(Console.ReadLine());
                switch (operacion)
                {
                    case 1: 
                        DarDeAltaPedido();
                        break;
                    case 2:
                        // AsignarPedidoACadete();
                        break;
                    case 3:
                        // CambiarDeEstadoPedido();
                        break;
                    case 4:
                        // CambiarPedidoDeCadete();
                        break;
                    default:
                        Console.WriteLine("Esa no es una opcion valida");
                        break;
                }

                Console.WriteLine("¿Quieres hacer otra operacion?   1- Si   2-No");
                int continuar = Convert.ToInt32(Console.ReadLine());
                if (continuar != 1)
                {
                    jornada = false;
                }
                
            } while (jornada);

        }

        private static Cliente GenerarCliente()
        {
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su direccion: ");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono: ");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese alguna referencia a su direccion");
            string referenciaDireccion = Console.ReadLine();
          
            Cliente nCliente = new Cliente(nombre, direccion, telefono, referenciaDireccion);
            return nCliente;

        }

        private static void DarDeAltaPedido()
        {
            Cliente nCliente = GenerarCliente();
            Console.WriteLine("Escriba que va a ordenar");
            string observacion = Console.ReadLine();
            Pedido nPedido = new Pedido(observacion, nCliente);
            HelperArchivos.InsertCliente(nCliente);
            HelperArchivos.InsertPedido(nPedido);
        }
    }
}
