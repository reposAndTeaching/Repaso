using System;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acaá se ejecuta todo el código, donde trabajo con los datos
            //instancio
            //hago operaciones
            //etc
            Persona p = new Persona("Benjamín", "Torres");
            Console.WriteLine(p.nombre);
            Console.WriteLine(p.apellido);
            Persona p2 = new Persona();
            Persona p3 = new Persona("Benjamín");
        }
    }

    class Persona
    {
        //ATRIBUTOS
        //CONSTRUCTORES
        //FUNCIONES O MÉTODOS
        //dlucero.informatica@gmail.com

        public string nombre;
        public string apellido;
        public int edad;

        public Persona()
        {

        }
       
        public Persona(string nombrePorDefecto)
        {
            nombre = nombrePorDefecto;
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }


        //FUNCIONES
        //
        //
        //
    }
}
