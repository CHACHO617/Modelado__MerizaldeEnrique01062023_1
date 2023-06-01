// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Persona Jose = new Persona("Nico", 21, "USA");
Console.WriteLine(Jose.imprimir());

class Persona
{
    public string nombre;
    public int edad;
    public string nacionalidad;
    public Persona(string nombre, int edad, string nacionalidad)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.nacionalidad = nacionalidad;
    }
    public string imprimir()
    {
        return "Nombre: " + nombre + " \nEdad: " + edad + " \nnacionalidad: " + nacionalidad;
    }
}

class Alumno : Persona
{
    public string curso;
    public Alumno(string nombre, int edad, string nacionalidad, string curso) : base(nombre, edad, nacionalidad)
    {
        this.curso = curso;
    }
    public string imprimir()
    {
        return "Nombre: " + nombre + " Edad: " + edad + " nacionalidad: " + nacionalidad + " Curso: " + curso;
    }
}

