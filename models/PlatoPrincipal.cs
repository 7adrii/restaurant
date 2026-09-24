using Models;

public class PlatoPrincipal : Producto
{
    public string Ingredientes {get; set;}

    public PlatoPrincipal(string nombre, decimal precio, string ingredientes) : base(nombre, precio)
    {
        Ingredientes = ingredientes;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Plato Principal: {Nombre}, Precio: {Precio}, Ingredientes: {Ingredientes}");
    }
}