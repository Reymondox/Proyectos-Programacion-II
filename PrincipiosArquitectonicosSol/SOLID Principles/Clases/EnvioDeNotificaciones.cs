using System;

namespace SOLIDPrinciples.Clases
{
    public class EnvioDeNotificaciones
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"\nEnviando un correo a la direccion '{email}' con el mensaje: {message}");
        }

        public void SendSms(string phoneNumber, string message)
        {
            Console.WriteLine($"\nEnviando un mensaje SMS al numero telefonico '{phoneNumber}' con el mensaje: {message}");
        }
    }
}
