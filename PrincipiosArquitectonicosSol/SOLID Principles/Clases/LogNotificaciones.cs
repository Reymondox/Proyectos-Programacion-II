using System;

namespace SOLIDPrinciples.Clases
{
    public class LogNotificaciones
    {
        List<String> LogMensajes = new List<String>();

        public void logNotification(string message)
        {
            LogMensajes.Add(message); 
            Console.WriteLine($"Se ha guardado correctamente en los logs el mensaje: {message}");
        }
    }
}
