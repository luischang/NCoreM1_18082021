using System;
using System.Collections.Generic;
using System.Linq;

namespace NCoreM1_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCurso = ".NET Core web con C# 2021 VS 16.11.1";
            int edad = 30;
            double monto = 750.50;

            var salario = "Cuatro mil dólares";
            string detalleEdad = String.Empty;

            var listado = new List<Persona>();
            var per1 = new Persona();
            per1.dni = "44776699";
            per1.nombre = "Carlos Zambrano";
            per1.telefono = "9977441122";

            var per2 = new Persona("4477447","Jose Reyes","995666454");

            var per3 = new Persona()
            {
                dni="44112211",
                nombre = "Luis Rojas",
                telefono = "9966332255"
            };

            listado.Add(per1);
            listado.Add(per2);
            listado.Add(per3);
            listado.Add(new Persona("44112233", "Raul Perez", "774411441"));

            foreach (var item in listado)
            {
                Console.WriteLine(item.dni + " " +
                                  item.nombre + " " +
                                  item.telefono);
            }

            var busqueda = listado
                .Where(x => x.dni == "44112211").FirstOrDefault();

            Console.WriteLine("Se encontró a: " + busqueda.nombre);

            Console.WriteLine("Hello World!");
        }
    }
}
