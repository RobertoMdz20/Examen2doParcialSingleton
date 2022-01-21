using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonExamen
{
    class Singleton
    {
        //Declaramos la instancia que será utilizada.
        private static Singleton InstanciaUnica;

        //Declaramos una propiedad para establecer un texto.
        private string mensaje;
        //Constructor privado del singleton.
        private Singleton()
        {
            mensaje = "";
        }
        //Metodo para poder generar la instancia unica
        public static Singleton GenerarInstancia()
        {
            //Se verifica la existencia de la instancia.
            if (InstanciaUnica == null)
            {
                //Si la instancia no existe, se procede a isntanciar.
                InstanciaUnica = new Singleton();
                //Muestra un mensaje de notificación de creación de la instancia.
                Console.WriteLine("\nLa instancia fue creada");
            }
            return InstanciaUnica;
        }

        //Metodo para mostrar un mensaje de bienvenida.
        public override string ToString()
        {
            return String.Format("\n**** Mensaje de bienvenida: {0} ****", mensaje);
        }
        //Metodo para ingresar el mensaje.
        public void IngresarMsj(string Imsj)
        {
            mensaje = Imsj;
        }

    }
}
