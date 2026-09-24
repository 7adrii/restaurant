using Models;

public class Postre : Producto
{
    public int Calorias {get; set;}
    public bool IsSugarFree {get; set;}

    public Postre(string nombre, decimal precio, int calorias, bool isSugarFree) : base(nombre, precio)
    {
        Calorias = calorias;
        IsSugarFree = isSugarFree;
    }

    public override void MostrarDetalles()
    {
        string llevaAzucar = IsSugarFree ? "Si" : "No";
        Console.WriteLine($"Postre: {Nombre}, Precio: {Precio:C}, Calorias: {Calorias} ¿LLeva azucar? {llevaAzucar}");
    }
}