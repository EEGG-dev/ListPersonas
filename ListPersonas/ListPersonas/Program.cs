using ListPersonas;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Persona> personas = new List<Persona>();

        string respuesta = "";

        while (respuesta != "n")
        {
            var persona = SolicitarPersona();

            personas.Add(persona);

            Console.WriteLine("¿Desea ingresar otra persona? (s/n)");
            respuesta = Console.ReadLine().ToLower();
        }
        var personasOrdenadas = OrdenarPorEdad(personas);

        MostrarLista(personasOrdenadas);
    }

    static Persona SolicitarPersona()
    {
        Console.WriteLine("Ingrese el nombre de la persona: ");
        string nombre = Console.ReadLine();

        int edad = 0;
        Console.WriteLine("Ingrese la edad de la persona: ");
        while (!ValidarEdad(Console.ReadLine(), out edad))
        {
            Console.WriteLine("Ingrese una edad valida.");
        }
        return new Persona(nombre, edad);
    }

    static bool ValidarEdad(string entrada, out int edad)
    {
        return int.TryParse(entrada, out edad);
    }

    static List<Persona> OrdenarPorEdad(List<Persona> personas)
    {
        return personas.OrderBy(p => p.Edad).ToList();
    }

    static void MostrarLista(List<Persona> personas)
    {
        foreach (var persona in personas)
        {
            Console.WriteLine($"{persona.Nombre} - {persona.Edad}");
        }
    }

}