using System;

namespace SingletonExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generamos la instancia a partir del metodo creado para realizar este proceso.
            Singleton Instacia1 = Singleton.GenerarInstancia();

            //Ingresamos el mensaje de bienvenida.
            Instacia1.IngresarMsj("Sean coordialmente invitados a esta app, espero que la disfruten y les sea de ayuda.");
            //Mostramos el mensaje de bienvenida.
            Console.WriteLine(Instacia1);
            Console.WriteLine("\n****----------****");

            //Para corroborar el funcionamiento del patrón, creamos otra instancia.
            Singleton Instacia2 = Singleton.GenerarInstancia();
            //Mostramos la instancia 2
            Console.WriteLine(Instacia2);

            /*El correcto funcionamiento del patrón de diseño singleton que solo se puede crear una instancia, se demuestra al momento de
            mostrar la instancia 2, mostrando el mismo mensaje de la instancia 1, ya que siempre devuelve la misma instancia.*/
        }
    }
}
