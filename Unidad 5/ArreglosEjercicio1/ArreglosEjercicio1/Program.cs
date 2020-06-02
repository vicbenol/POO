using System;

namespace ArreglosEjercicio1
{
    class Cliente
    {
        //aqui agregamos todas las variables de la clase 
        public string codigo;
        public string nombre;
        public string apellidos;
        public string DNI; 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int totalvec;
            string c, n, a, d;
            //El objeto de la clase 
            Cliente objcliente = new Cliente();
            //Para saber la cantidad de clientes que agregara 
            Console.Write("Ingrese el numero de clietes: ");
            totalvec = int.Parse(Console.ReadLine());
            Cliente[] vecClientes = new Cliente[totalvec];
            //Aqui se agrega un bucle para que finalice en el vector agregado
            for (int i = 0; i < vecClientes.Length; i++)
            {
                //Para almacenar los datos en el objeto
                Console.Write("Codigo del cliente: ");
                objcliente.codigo = Console.ReadLine();
                Console.Write("Nombre del cliente: ");
                objcliente.nombre = Console.ReadLine();
                Console.Write("Apellido del cliente: ");
                objcliente.apellidos = Console.ReadLine();
                Console.Write("DNI: ");
                objcliente.DNI = Console.ReadLine();
                vecClientes[i] = objcliente;
            }
            //Este es para que no se cierre automaticamente solo 
            Console.ReadKey();
        }
    }
}
