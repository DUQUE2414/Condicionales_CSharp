class Program
{

    public static void Main(string[] args)
    {

        string especieMascota = "perro";   // "perro", "gato", "conejo", "reptil"
        int edadMascota = 7;               // edad en años
        double peso = 28.5;                // peso en kilogramos
        bool tieneVacunasAlDia = false;
        bool esSocio = true;
        string motivoConsulta = "cirugia";
        string AlertaVacuna;
        decimal costoBase;
        string recomendacion;

        Console.WriteLine("¿Cómo te llamas?");
        string? nombre = Console.ReadLine(); // Guarda lo que el usuario escriba
        Console.WriteLine($"Hola {nombre}");


        //Parte 1 — Clasificación por etapa de vida
        string etapaVida = edadMascota switch
        {
            < 1 => "Cachorro",
            > 1 and <= 3 => "Joven",
            >= 4 and <= 8 => "Adulto",
            > 8 => "Senior",
            _ => "Edad de vida no valida"
        };


        //Parte 2 — Alerta de vacunación
        if ((especieMascota == "perro" || especieMascota == "gato") && !tieneVacunasAlDia)
        {
            AlertaVacuna = "ALERTA: vacunación urgente requerida";
        }
        else if ((especieMascota == "perro" || especieMascota == "gato") && tieneVacunasAlDia)
        {
            AlertaVacuna = "Vacunación al día";
        }
        else
        {
            AlertaVacuna = "Esquema de vacunación no aplica";
        }

        //Parte 3 — Costo base de la consulta
        switch (motivoConsulta)
        {
            case "vacuna":
                costoBase = 35000m;
                break;

            case "revision":
                costoBase = 50000m;
                break;

            case "cirugia":
                costoBase = 280000;
                break;

            case "urgencia":
                costoBase = 150000;
                break;

            default:
                costoBase = 0m;
                break;
        }


        //Parte 4 — Descuento por membresía y peso

        double porcentajeDescuento = (esSocio && peso > 25) ? 15.0 : esSocio ? 10.0 : 0.0;
        decimal descuento = costoBase * (decimal)(porcentajeDescuento / 100);
        decimal costoFinal = costoBase - descuento;


        //Parte 5 — Recomendación post-consulta
        if (motivoConsulta == "cirugia")
        {
            if (etapaVida == "senior")
            {
                recomendacion = "Reposo absoluto por 10 días, control post-operatorio obligatorio";
            }

            else
            {
                recomendacion = "Reposo por 5 días, evitar ejercicio intenso";
            }
        }

        else if (motivoConsulta == "urgencia")
        {
            if (!tieneVacunasAlDia)
            {
                recomendacion = "Atender urgencia y programar vacunación inmediata";
            }

            else
            {
                recomendacion = "Seguimiento en 48 horas";
            }

        }
        else
        {
            recomendacion = "Seguimiento en próxima consulta de rutina";
        }

        // Parte 6 — Impresión del Reporte Final
        Console.WriteLine("=== Reporte de Atención Veterinaria ===");
        Console.WriteLine($"Mascota: {especieMascota} | Edad: {edadMascota} años | Etapa: {etapaVida}");
        Console.WriteLine($"Estado de vacunación: {AlertaVacuna}");
        Console.WriteLine($"Motivo: {motivoConsulta} | Costo base: ${costoBase:N0}");
        Console.WriteLine($"Descuento: {porcentajeDescuento}% | Costo final: ${costoFinal:N0}");
        Console.WriteLine($"Recomendación: {recomendacion}");
    }
}

