using SOLIDPrinciples.Clases;

namespace SOLIDPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var correo1 = new EnvioDeNotificaciones();
            var correo1log = new LogNotificaciones();

            Console.WriteLine("----Servicio de notificaciones----");

            Console.WriteLine("\nServicios disponibles:\n");

            Console.WriteLine("1 - Enviar un correo");
            Console.WriteLine("2 - Enviar un mensaje SMS");

            Console.WriteLine("\nDigite el numero de la operacion a realizar: ");
            int decision = int.Parse(Console.ReadLine()!);

            if (decision == 1)
            {
                Console.WriteLine("\nEscriba la direccion email del correo a enviar: ");
                String email = Console.ReadLine()!;

                Console.WriteLine("\nEscriba el mensaje a enviar: ");
                String message = Console.ReadLine()!;

                correo1.SendEmail(email, message);
                correo1log.logNotification(message);
            }
            else if(decision == 2)
            {
                Console.WriteLine("\nEscriba el numero de telefono a enviar el sms: ");
                String phoneNumber = Console.ReadLine()!;

                Console.WriteLine("\nEscriba el mensaje a enviar: ");
                String message = Console.ReadLine()!;

                correo1.SendSms(phoneNumber, message);
                correo1log.logNotification(message);
            }
            else
            {
                Console.WriteLine("\nHa seleccionado la operacion incorrecta.");
            }
        }
    }
}
