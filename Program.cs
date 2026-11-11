int tipoUsuario;
//Zona de admin
string usuarioAdmin = "Admin";
string contrasenaAdmin = "FitZone123";
string intentoUsuario;
string intentoContrasena;

int opcionAdmin;
int opcionClaseAdmin;

int opcionClaseYogaAdmin;
int anadirPersonasYoga;

int opcionClaseCrossfitAdmin;
int anadirPersonasCrossfit;

string nombreNuevoSocio;
string apellidosNuevoSocio;
int edadNuevoSocio;

double cuotaMensual = 32.0;
double cuotaNuevoSocio;

int nuevoSocioClase;

int socios = 71;
int aforoYoga = 10;
int aforoCrossfit = 8;
int aforoMaximoYoga = 20;
int aforoMaximoCrossfit = 15;

int opcionConsultarIngresos;

double ingresosMensuales;
double ingresosAnuales;

// Zona de usuario estandar
int opcionUsuario;
string nombreCliente;
int edadCliente;
int opcionClase;
//Estas 2 variables nombreClase y precioClase les doy valor porque si no dan error en unos calculos al final del codigo, no se porque la verdad
string nombreClase = "";
double precioClase = 0;
int opcionExtra;
int numExtras;
double precioExtras;
int tipoInscripcion;
double acompanante;
double descuento;
double total;
double entregado;

int numDeOperaciones = 0;
double recaudacion = 0;
double operacionMasCara = 0;
string clienteMasCara = "";

do
{
    Console.WriteLine("--- FitZone ---");
    Console.WriteLine("Tipo de usuario: ");
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
                    Console.WriteLine();
                    Console.WriteLine("--- Acceso panel administrador ---");
                    Console.WriteLine();
                    Console.WriteLine("Que desea hacer");
                    Console.WriteLine("1. Controlar aforo clases");
                    Console.WriteLine("2. Dar de alta Nuevo socio");
                    Console.WriteLine("3. Consultar ingresos");
                    opcionAdmin = int.Parse(Console.ReadLine()!);

                    switch (opcionAdmin)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("--- Control aforo clases ---");
                            Console.WriteLine();
                            Console.WriteLine("1. Yoga");
                            Console.WriteLine("2. Crossfit");
                            Console.WriteLine("3. Salir");
                            Console.WriteLine("De que clase desea controlar el aforo (1 para yoga, 2 para crossfit o 3 para salir): ");
                            opcionClaseAdmin = int.Parse(Console.ReadLine()!);

                            switch (opcionClaseAdmin)
                            {
                                case 1:
                                    Console.WriteLine();
                                    Console.WriteLine("--- Gestión clases de yoga ---");
                                    Console.WriteLine();
                                    Console.WriteLine("1. Añadir personas a clase de yoga");
                                    Console.WriteLine("2. Quitar personas de clase de yoga");
                                    Console.WriteLine("Que desea hacer: ");
                                    opcionClaseYogaAdmin = int.Parse(Console.ReadLine()!);

                                    if (opcionClaseYogaAdmin == 1)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Cuantas personas deseas añadir: ");
                                        anadirPersonasYoga = int.Parse(Console.ReadLine()!);
                                        //Aqui hacemos esta comprobacion para que no podamos añadir mas personas que el maximo del aforo (20)
                                        if (anadirPersonasYoga > (aforoMaximoYoga - aforoYoga))
                                        {
                                            Console.WriteLine("Esta cantidad supera el número de plazas disponibles");
                                            Console.WriteLine("El número de plazas disponibles actualmente es de: " + (aforoMaximoYoga - aforoYoga));
                                        }
                                        else
                                        {
                                            aforoYoga = aforoYoga + anadirPersonasYoga;
                                            Console.WriteLine("Se han añadido 4 personas a la clase de yoga correctamente");
                                            Console.WriteLine("El aforo actual es de " + aforoYoga + "/" + aforoMaximoYoga + " plazas de yoga");
                                        }
                                    }
                                    break;

                                case 2:
                                    Console.WriteLine();
                                    Console.WriteLine("--- Gestión clases de crossfit ---");
                                    Console.WriteLine();
                                    Console.WriteLine("1. Añadir personas a clase de crossfit");
                                    Console.WriteLine("2. Quitar personas de clase de crossfit");
                                    Console.WriteLine("Que desea hacer: ");
                                    opcionClaseCrossfitAdmin = int.Parse(Console.ReadLine()!);

                                    if (opcionClaseCrossfitAdmin == 1)
                                    {
                                        Console.WriteLine("Cuantas personas deseas añadir: ");
                                        anadirPersonasCrossfit = int.Parse(Console.ReadLine()!);
                                        if (anadirPersonasCrossfit > (aforoMaximoCrossfit - aforoCrossfit))
                                        {
                                            Console.WriteLine("Esta cantidad supera el número de plazas disponibles");
                                            Console.WriteLine("El número de plazas disponibles actualmente es de: " + (aforoMaximoCrossfit - aforoCrossfit));
                                        }
                                        else
                                        {
                                            aforoCrossfit = aforoCrossfit + anadirPersonasCrossfit;
                                            Console.WriteLine("El aforo actual es de " + aforoCrossfit + "/" + aforoMaximoCrossfit + " plazas de yoga");
                                        }
                                    }
                                    break;
                                case 3:
                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("--- Menú alta nuevo socio ---");
                            Console.WriteLine();

                            Console.WriteLine("Nombre: ");
                            nombreNuevoSocio = Console.ReadLine()!;
                            Console.WriteLine();
                            Console.WriteLine("Apellidos: ");
                            apellidosNuevoSocio = Console.ReadLine()!;
                            Console.WriteLine();
                            Console.WriteLine("Edad: ");
                            edadNuevoSocio = int.Parse(Console.ReadLine()!);

                            cuotaNuevoSocio = cuotaMensual;

                            Console.WriteLine();
                            Console.WriteLine("--- Seleccion de clase ---");
                            Console.WriteLine("1. Yoga: Cuota mensual básica + 11,50€");
                            Console.WriteLine("2. Crossfit: Cuota normal + 13€");
                            Console.WriteLine("3. Libre: Cuota normal de 32€");
                            Console.WriteLine("Descuento del 10% para personas mde 65 años o más");
                            Console.WriteLine("");
                            Console.WriteLine("Selecciona una opción");
                            nuevoSocioClase = int.Parse(Console.ReadLine()!);

                            switch (nuevoSocioClase)
                            {
                                //Dependiendo de la clase a la que añadamos al socio se suma un precio u otro,
                                //todo en variables que solo existen dentro del switch para que no cambiemos el precio de forma permanente
                                case 1:
                                    cuotaNuevoSocio += 11.5;
                                    aforoYoga = aforoYoga + 1;
                                    socios = socios + 1;
                                    break;
                                case 2:
                                    cuotaNuevoSocio += 13;
                                    aforoCrossfit = aforoCrossfit + 1;
                                    socios = socios + 1;
                                    break;
                                case 3:
                                    socios = socios + 1;
                                    break;
                                default:
                                    Console.WriteLine("Opción incorrecta");
                                    break;
                            }

                            if (edadNuevoSocio >= 65)
                            {
                                cuotaNuevoSocio = cuotaNuevoSocio * 0.9;
                            }

                            Console.WriteLine();
                            Console.WriteLine("--- Resumen nuevo socio ---");
                            Console.WriteLine();
                            Console.WriteLine("Nombre: " + nombreNuevoSocio);
                            Console.WriteLine("Apellidos: " + apellidosNuevoSocio);
                            Console.WriteLine("Edad: " + edadNuevoSocio);
                            Console.WriteLine("Precio: " + cuotaNuevoSocio);
                            break;
                        case 3:
                            Console.WriteLine("--- Consultar ingresos ---");
                            Console.WriteLine("1. Consultar ingresos mensuales");
                            Console.WriteLine("2. Consultar ingresos anuales");
                            Console.WriteLine("Que ingresos quieres consultar");
                            opcionConsultarIngresos = int.Parse(Console.ReadLine()!);

                            ingresosMensuales = (aforoYoga * 43.5) + (aforoCrossfit * 45) + ((socios - (aforoYoga + aforoCrossfit)) * 32);
                            ingresosAnuales = ingresosMensuales * 12;

                            switch (opcionConsultarIngresos)
                            {
                                case 1:
                                    Console.WriteLine("Ingresos mensuales: " + ingresosMensuales + "€");
                                    break;
                                case 2:
                                    Console.WriteLine("Ingresos anuales: " + ingresosAnuales + "€");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                }
            }
            break;
        case 2:
            Console.WriteLine();
            Console.WriteLine("--- Zona usuario ---");
            Console.WriteLine("1. Nueva inscripción");
            Console.WriteLine("2. Consultar caja");
            opcionUsuario = int.Parse(Console.ReadLine()!);

            switch (opcionUsuario)
            {
                case 1:
                    numExtras = 0;
                    precioExtras = 0;
                    acompanante = 0;
                    descuento = 0;

                    Console.WriteLine("Nombre del cliente:");
                    nombreCliente = Console.ReadLine()!.Trim();
                    Console.WriteLine("Edad:");
                    edadCliente = int.Parse(Console.ReadLine()!);

                    do
                    {
                        Console.WriteLine("1. Yoga: 43,50€");
                        Console.WriteLine("2. Crossfit: 45€");
                        Console.WriteLine("3. Libre: 32€");
                        opcionClase = int.Parse(Console.ReadLine()!);
                        switch (opcionClase)
                        {

                            case 1:
                                nombreClase = "Yoga";
                                precioClase = cuotaMensual + 11.5;
                                break;
                            case 2:
                                nombreClase = "Crossfit";
                                precioClase = cuotaMensual + 13;
                                break;
                            case 3:
                                nombreClase = "Libre";
                                precioClase = cuotaMensual;
                                break;
                            default:
                                Console.WriteLine("Opcion incorrecta, escoge una opcion entre el 1 y el 3");
                                break;
                        }
                    } while (opcionClase < 1 || opcionClase > 3);
                    Console.WriteLine("¿Taquilla por 8€ extra? 1para si 2 para no");
                    opcionExtra = int.Parse(Console.ReadLine()!);
                    if (opcionExtra == 1)
                    {
                        precioExtras += 8;
                        numExtras++;
                    }

                    Console.WriteLine("¿Toalla por 5€ extra? 1 para si 2 para no");
                    opcionExtra = int.Parse(Console.ReadLine()!);
                    if (opcionExtra == 1)
                    {
                        precioExtras += 5;
                        numExtras++;
                    }

                    Console.WriteLine("¿Entrenador personal por 20€ extra? 1 para si 2 para no");
                    opcionExtra = int.Parse(Console.ReadLine()!);
                    if (opcionExtra == 1)
                    {
                        precioExtras += 20;
                        numExtras++;
                    }

                    Console.WriteLine("1. Individual");
                    Console.WriteLine("2. Con acompañante (+15€)");
                    tipoInscripcion = int.Parse(Console.ReadLine()!);
                    if (tipoInscripcion == 2)
                    {
                        acompanante = 15;
                    }
                    // Revisar error luego
                    if (edadCliente >= 65)
                    {
                        descuento = (precioClase + precioExtras) * 0.10;
                    }
                    total = precioClase + precioExtras - descuento + acompanante;
                    Console.WriteLine("TOTAL A PAGAR: " + total.ToString("F2") + "€");

                    do
                    {
                        Console.WriteLine("Dinero entregado:");
                        entregado = double.Parse(Console.ReadLine()!);
                        if (entregado < total)
                        {
                            Console.WriteLine("Pago insuficiente");
                        }
                    }
                    while (entregado < total);

                    numDeOperaciones++;
                    recaudacion += total;
                    if (numDeOperaciones == 1 || total > operacionMasCara)
                    {
                        operacionMasCara = total;
                        clienteMasCara = nombreCliente;
                    }

                    Console.WriteLine("--- Ticket nº " + numDeOperaciones + " ---");
                    Console.WriteLine("Cliente: " + nombreCliente);
                    Console.WriteLine("Clase: " + nombreClase + " " + precioClase.ToString("F2") + "€");
                    Console.WriteLine("Extras: " + numExtras + " (" + precioExtras.ToString("F2") + "€)");
                    Console.WriteLine("Descuento: -" + descuento.ToString("F2") + "€");
                    Console.WriteLine("Suplemento: " + acompanante.ToString("F2") + "€");
                    Console.WriteLine("Total: " + total.ToString("F2") + "€");
                    Console.WriteLine("Entregado: " + entregado.ToString("F2") + "€");
                    Console.WriteLine("Cambio: " + (entregado - total).ToString("F2") + "€");
                    break;

                case 2:
                    if (numDeOperaciones == 0)
                    {
                        Console.WriteLine("Todavia no hay operaciones cobradas");
                    }
                    else
                    {
                        Console.WriteLine("Operaciones: " + numDeOperaciones);
                        Console.WriteLine("Recaudación: " + recaudacion.ToString("F2") + "€");
                        Console.WriteLine("Cobro medio: " + (recaudacion / numDeOperaciones).ToString("F2") + "€");
                        Console.WriteLine("Operación más cara: " + operacionMasCara.ToString("F2") + "€ (" + clienteMasCara + ")");
                    }
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
            break;
    }
}
while (tipoUsuario != 3);