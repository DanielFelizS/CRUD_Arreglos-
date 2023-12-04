using System;
using System.Collections.Generic;

namespace CRUD_Array
{
    class CRUD
    {
        static void Main(string[] args)
        {
            int id, eleccion;
            string nombre, apellido, sexo;
            List<Persona> datos = new List<Persona>();

            while (true)
            {
                Console.WriteLine("CRUD con arreglos");
                Console.WriteLine("Escoja la accion que quiere hacer");
                Console.WriteLine("1. Agregar datos");
                Console.WriteLine("2. Editar datos");
                Console.WriteLine("3. Eliminar datos");
                Console.WriteLine("4. Consultar datos");
                Console.WriteLine("5. Salir del programa");

                eleccion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();                 

                    if(eleccion == 1){
                        try
                        {           
                            Console.WriteLine("Ingresa el id de la persona");
                            id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingresa el nombre de la persona");
                            nombre = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Ingresa el apellido de la persona");
                            apellido = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Ingresa el sexo de la persona (M o F)");
                            sexo = Convert.ToString(Console.ReadLine());

                            if(id >= 1) datos.Add(new Persona(id, nombre, apellido, sexo));
                            else if (sexo != "M" || sexo != "F") Console.WriteLine("Ingrese solo el primer carácter del sexo");
                            else Console.WriteLine("Ingrese un id correcto");
                            // Console.Clear();

                            Console.WriteLine("Id  Nombre  Apellido  Sexo ");
                            foreach (Persona persona in datos)
                            {
                                Console.WriteLine($"{persona.ID}   {persona.Nombre}   {persona.Apellido}   {persona.Sexo}");
                            }
                        }
                        catch (System.Exception ex)
                        {
                            Console.Clear();
                            Console.WriteLine($"Los datos no se pudieron agregar {ex.ToString()}");
                        }
                    }
                else if (eleccion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa el id de la persona que deseas editar");
                    id = Convert.ToInt32(Console.ReadLine());

                    // Buscar la persona con el ID especificado
                    Persona personaEditar = datos.Find(persona => persona.ID == id);

                    if (personaEditar != null)
                    {
                        Console.WriteLine($"Seleccionaste a la persona con ID {personaEditar.ID}:");
                        Console.WriteLine("1. Editar nombre");
                        Console.WriteLine("2. Editar apellido");
                        Console.WriteLine("3. Editar sexo");
                        Console.WriteLine("4. Editar Todos los datos");
                        Console.WriteLine("5. Cancelar");

                        int opcion = Convert.ToInt32(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Ingresa el nuevo nombre de la persona:");
                                nombre = Convert.ToString(Console.ReadLine());
                                personaEditar.Nombre = nombre;
                                Console.WriteLine("Nombre actualizado exitosamente.");
                                break;

                            case 2:
                                Console.WriteLine("Ingresa el nuevo apellido de la persona:");
                                apellido = Convert.ToString(Console.ReadLine());
                                personaEditar.Apellido = apellido;
                                Console.WriteLine("Apellido actualizado exitosamente.");
                                break;

                            case 3:
                                Console.WriteLine("Ingresa el nuevo sexo de la persona (M o F):");
                                sexo = Convert.ToString(Console.ReadLine());
                                personaEditar.Sexo = sexo;
                                Console.WriteLine("Sexo actualizado exitosamente.");
                                break;

                            case 4:
                                Console.WriteLine("Ingresa el nuevo nombre de la persona");
                                nombre = Convert.ToString(Console.ReadLine());

                                Console.WriteLine("Ingresa el nuevo apellido de la persona");
                                apellido = Convert.ToString(Console.ReadLine());

                                Console.WriteLine("Ingresa el nuevo sexo de la persona (M o F)");
                                sexo = Convert.ToString(Console.ReadLine());

                                // Actualizar los atributos de la persona
                                personaEditar.Nombre = nombre;
                                personaEditar.Apellido = apellido;
                                personaEditar.Sexo = sexo;
                                break;
                                
                            case 5:
                                Console.WriteLine("Edición cancelada.");
                                break;
                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }

                        // Mostrar la lista después de la edición
                        Console.WriteLine("Id  Nombre  Apellido  Sexo ");
                        foreach (Persona persona in datos)
                        {
                            Console.WriteLine($"{persona.ID}   {persona.Nombre}   {persona.Apellido}   {persona.Sexo}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ninguna persona con el ID especificado.");
                    }
                    // break;
                }
            
                    else if(eleccion == 3){
                        // Console.Clear();
                        Console.WriteLine("Eliminar todos los datos de una persona");
                        Console.WriteLine("Ingrese el id de la persona");
                        id = Convert.ToInt32(Console.ReadLine());

                        // Eliminar la persona con el ID especificado
                        datos.RemoveAll(persona => persona.ID == id);
                        // Math.abs();
                        foreach (Persona persona in datos)
                        {
                            Console.WriteLine($"{persona.ID}   {persona.Nombre}   {persona.Apellido}   {persona.Sexo}");
                        }
                    }
                    else if (eleccion == 4)
                    {
                        // Console.Clear();
                        Console.WriteLine("Id  Nombre  Apellido  Sexo ");
                        foreach (Persona persona in datos)
                        {
                            Console.WriteLine($"{persona.ID}   {persona.Nombre}   {persona.Apellido}   {persona.Sexo}");
                        }
                    }
                    else if(eleccion == 5){
                        Console.Clear();
                        Console.WriteLine("Has salido del programa");
                        break;
                    }
                    else{
                        Console.Clear();
                        Console.WriteLine("Escoja una opcion correcta");
                    } 
                }
            }
        }

class Persona
{
    private int Id;     
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Sexo { get; set; }

    public int ID {
        get {return Id;}
        set {Id = value;}
    }

    public Persona(int id, string nombre, string apellido, string sexo)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Sexo = sexo;
    }
}
}