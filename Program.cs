using Models;

PlatoPrincipal plato = new PlatoPrincipal("Plato Combinado", 12.50m, "Pollo, patatas, pimientos");
plato.MostrarDetalles();

Bebida bebida = new Bebida("CocaCola", 8.5m, true);
bebida.MostrarDetalles();

Postre postre = new Postre("Tarta de queso", 12.45m, 300, false);
postre.MostrarDetalles();

Entrante bravas = new Entrante("Patatas Bravas", 7.50m, 2, true);
Entrante nachos = new Entrante("Nachos", 9.99m, 4, true);
Entrante ensaladilla = new Entrante("Ensaladilla Rusa", 13, 1, false);

bravas.MostrarDetalles();
nachos.MostrarDetalles();
ensaladilla.MostrarDetalles();


List<Producto> carta = new List<Producto>
{
    new Entrante("Patatas Bravas", 6m, 2, false), 
    new Entrante("Nachos", 8m, 3, false), 
    new PlatoPrincipal("Pizza", 11m, "Tomate, Queso, Oregano"), 
    new PlatoPrincipal("Migas", 12.50m, "Migas, Torreznos, Huevos"), 
    new Postre("Tarta de queso", 6m, 400, false), 
    new Postre("Contesa", 5m, 200, false), 
    new Bebida("CocaCola", 2.50m, false), 
    new Bebida("Pacharan con hielo", 4m, true)
};

Console.WriteLine("====CARTA====");

int numeracion = 1;

foreach (Producto producto in carta)
{
    Console.WriteLine($"{numeracion}. {producto.Nombre} - {producto.Precio:C}");
    numeracion++;
}


Console.WriteLine("====BEBIDAS====");

int numeracion2 = 1;

foreach (Producto producto in carta)
{
    if (producto is Bebida)
    {
        Console.WriteLine($"{numeracion2}. {producto.Nombre} - {producto.Precio:C}");
        numeracion++;
    }
    
}