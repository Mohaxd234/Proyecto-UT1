namespace Proyecto_UT1;

class Program
{
    static void Main(string[] args)
    {
        int tipoUsuario;
        
        string usuarioAdmin = "Admin";
        string contrasenaAdmin = "FitZone123";
        string intentoUsuario;
        string intentoContrasena;
        int opcionAdmin;


        do
        {
            Console.WriteLine("--- FitZone ---");
            Console.Write("Tipo de usuario: ");
            Console.WriteLine("1. Administrador");
            Console.WriteLine("2. Usuario");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Con que tipo de usuario desea ingresar:");
            tipoUsuario = int.Parse(Console.ReadLine()!);

            switch (tipoUsuario)
            {
                case 1:
                    Console.WriteLine("Introduzca nombre de usuario de administrador:");
                    intentoUsuario = Console.ReadLine()!;
                    if (intentoUsuario != usuarioAdmin)
                    {
                        Console.WriteLine("Usuario incorrecto");
                    }
                    else
                    {
                        Console.WriteLine("Introduce la contraseña de administrador");
                        intentoContrasena = Console.ReadLine()!;
                        if (intentoContrasena == contrasenaAdmin)
                        {
                            Console.WriteLine("Acceso concedido");
                            Console.WriteLine("Que desea hacer");
                            Console.WriteLine("1. Controlar aforo clases");
                            Console.WriteLine("2. Dar de alta Nuevo socio");
                            Console.WriteLine("3. Dar de baja socio");
                            opcionAdmin = int.Parse(Console.ReadLine()!);

                            switch (opcionAdmin)
                            {
                                case 1:
                                    Console.WriteLine("De que clase desea controlar el aforo");
                                    Console.WriteLine("1. Yoga");
                                    Console.WriteLine("2. Crossfit");
                                    Console.WriteLine("3. Salir");
                                    
                                    break;
                            }
                        } else
                        {
                            Console.WriteLine("Contraseña incorrecta");
                        }
                    }
                    break;
            }
        }
        while (tipoUsuario != 3);
    }
}