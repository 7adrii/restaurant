using Models;

public class Entrante : Producto
{
    int NumPersonasPensado {get; set;}
    bool EsCaliente {get; set;}
    public Entrante(string nombre, decimal precio, int numPersonasPensado, bool esCaliente) : base(nombre, precio)
    {
        NumPersonasPensado = numPersonasPensado;
        EsCaliente = esCaliente;
    }

    public override void MostrarDetalles()
    {
        string Quema = EsCaliente ? "Si" : "No";
        Console.WriteLine($"Nombre: {Nombre}, Precio: {Precio:C}, Esta pensado para {NumPersonasPensado} personas, ¿Es un plato caliente? {Quema}");
    }
}