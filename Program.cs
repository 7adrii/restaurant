using Models;

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

// Ejercicio 16: Crear un pedido.
List<Producto> pedido = new List<Producto>();

// Ejercicio 15: Menu principal

bool salir = false;

while(!salir) {
    MostrarMenuPrincipal();

    string? entradaOpcion = Console.ReadLine();

    if(!int.TryParse(entradaOpcion, out int opcion)) {
        Console.WriteLine("\nDebes introducir un numero valido.");
        continue;
    }
    Console.WriteLine();

    switch (opcion) {
        case 1: 
            MostrarCarta(carta);
            break;
        case 2: 
            AgregarProductoAlPedido(carta, pedido);
            break;
        case 3: 
            MostrarPedido(pedido);
            break;
        case 4:
            EliminarProductoDelPedido(pedido);
            break;
        case 5:
            FinalizarPedido(pedido);
            break;
        case 6: 
            BuscarProducto(carta);
            break;
        case 7: 
            MostrarProductosPorPrecio(carta);
            break;
        case 8: 
            MostrarProductoMasCaro(carta);
            break;
        case 0: 
            salir = true;
            Console.WriteLine("Gracias por su visita.");
            break;
        default: 
            Console.WriteLine("Opcion no valida. Intentalo de nuevo.");
            break;
    }
}

static void MostrarMenuPrincipal() {
        Console.WriteLine("\n===============");
        Console.WriteLine("   Restaurante   ");
        Console.WriteLine("1. Ver Carta.");
        Console.WriteLine("2. Añadir productos al pedido.");
        Console.WriteLine("3. Ver pedido.");
        Console.WriteLine("4. Eliminar producto del pedido.");
        Console.WriteLine("5. Finalizar pedido.");
        Console.WriteLine("6. Buscar producto.");
        Console.WriteLine("7. Productos por precio.");
        Console.WriteLine("8. Producto mas caro.");
        Console.WriteLine("0. Salir.");
        Console.WriteLine("===============");
        Console.WriteLine("Elige una opcion: ");
    }

// Ejercicio 7: Seleccionar producto.
static void ElegirProducto(List<Producto> carta) {
    Console.WriteLine("=====================");
    Console.Write("¿Que producto quieres?");
    string? entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out int seleccion))
    {
        Console.WriteLine("Debes introducir un numero.");
    }
    // Ejercicio 8: Validar la seleccion.
    else if (seleccion < 1 || seleccion > carta.Count)
    {
        Console.WriteLine("Ese producto no existe.");
    }
    else
    {
        Producto elegido = carta[seleccion - 1];
        Console.WriteLine($"Has elegido: {elegido.Nombre} - {elegido.Precio:C}");
    }
}

// Ejercicio 9: Buscar un producto por nombre.
static void BuscarProducto(List<Producto> carta){ 
    Console.Write("Pon el nombre del producto: ");
    string? busqueda = Console.ReadLine();

    Producto? encontrado = null;

    foreach(Producto producto in carta)
    {
        if(string.Equals(producto.Nombre, busqueda, StringComparison.OrdinalIgnoreCase))
        {
            encontrado = producto;
            break;
        }
    }

    if(encontrado != null)
    {
        Console.WriteLine($"Producto encontrado: {encontrado.Nombre} - {encontrado.Precio:C}");
    } else
    {
        Console.WriteLine("No se ha encontrado el producto.");
    }
}


// Ejercicio 10: Producto por precio.
static void MostrarProductosPorPrecio(List<Producto> carta) {
    Console.Write("Precio maximo: ");
    if(!decimal.TryParse(Console.ReadLine(), out decimal precioMaximo))
    {
        Console.WriteLine("Debes introducir un precio valido");
    } else
    {
        Console.WriteLine($"Prodcutos hasta {precioMaximo:C}");

        bool hayProductos = false;

        foreach(Producto producto in carta)
        {
            if (producto.Precio <= precioMaximo)
            {
                Console.WriteLine($"{producto.Nombre} - {producto.Precio:C}");
                hayProductos = true;
            }
        }

        if(!hayProductos)
        {
            Console.WriteLine("No hay ningun producto con ese precio o inferior.");
        }
    }
}


// Ejercicio 11: Producto mas caro.
static void MostrarProductoMasCaro(List<Producto> carta) {
    Producto masCaro = carta[0];
    foreach(Producto producto in carta)
    {
        if(producto.Precio > masCaro.Precio)
        {
            masCaro = producto;
        }
    }
    Console.WriteLine($"El producto mas caro es: {masCaro.Nombre} - {masCaro.Precio}");
}

// Ejercicio 12: Extraer la visualizacion de la carta a un metodo.
static void MostrarCarta(List<Producto> carta) {
    Console.WriteLine("---CARTA---");
    for(int i = 0; i < carta.Count; i++) {
        Console.WriteLine($"{i + 1}. {carta[i].Nombre} - {carta[i].Precio:C}");
    }
}

// Ejercicio 16: Crear un pedido.
static void AgregarProductoAlPedido(List<Producto> carta, List<Producto> pedido) {
    MostrarCarta(carta);

    Console.WriteLine("Que producto quieres?");
    string? entrada = Console.ReadLine();

    if(!int.TryParse(entrada, out int seleccion)) {
        Console.WriteLine("Debes introducir un numero");
    } else if (seleccion < 1 || seleccion > carta.Count){
        Console.WriteLine("Ese producto no existe");
    } else {
        Producto elegido = carta[seleccion - 1];
        pedido.Add(elegido);
        Console.WriteLine($"{elegido.Nombre} añadido al pedido");
    }
}

// Ejercicio 17: Mostrar el pedido.
static void MostrarPedido(List<Producto> pedido) {
    Console.WriteLine("--- Tu pedido ---");
    if(pedido.Count == 0) {
        Console.WriteLine("El pedido esta vacio.");
    }

    decimal total = 0;
    foreach(Producto producto in pedido) {
        Console.WriteLine($"{producto.Nombre} - {producto.Precio:C}");
        total += producto.Precio;
    }

    Console.WriteLine("----------");
    Console.WriteLine($"Total: {total:C}");
}

// Ejercicio 18: Eliminar un producto del pedido.
static void EliminarProductoDelPedido(List<Producto> pedido) {
    if(pedido.Count == 0) {
        Console.WriteLine("El pedido esta vacio.");
        return;
    }

    Console.WriteLine("--- Tu pedido ---");
    for(int i = 0; i < pedido.Count; i++) {
        Console.WriteLine($"{i + 1}. {pedido[i].Nombre} - {pedido[i].Precio:C}");
    }

    Console.Write("\nQue producto quieres quitar?");
    string? entrada = Console.ReadLine();

    if(!int.TryParse(entrada, out int seleccion)) {
        Console.WriteLine("Tienes que introducir un numero.");
    } else if (seleccion < 1 || seleccion > pedido.Count) {
        Console.WriteLine("Ese producto no esta en tu pedido");
    } else {
        Producto eliminado = pedido[seleccion - 1];
        pedido.RemoveAt(seleccion - 1);
        Console.WriteLine($"{eliminado.Nombre} eliminado del pedido.");
    }
}

// Ejercicio 19: Finalizar el pedido.
static void FinalizarPedido(List<Producto> pedido) {
    if(pedido.Count == 0) {
        Console.WriteLine("El pedido esta vacio. No se puede generar el ticket.");
        return;
    }

    Console.WriteLine("==== TICKET ====");
    decimal total = 0;

    foreach(Producto producto in pedido) {
        Console.WriteLine($"{producto.Nombre} - {producto.Precio:C}");
        total += producto.Precio;
    }

    Console.WriteLine("-------------------------");
    Console.WriteLine($"Productos: {pedido.Count}");
    Console.WriteLine($"Total: {total:C}");
    Console.WriteLine("\nGracias por tu visita.");

    pedido.Clear();
}

//MostrarCarta(carta);

// Ejercicio 13: Separar operaciones en metodos.
//ElegirProducto(carta);
//BuscarProducto(carta);
//MostrarProductosPorPrecio(carta);
//MostrarProductoMasCaro(carta);



/*
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

// Ejercicio 3: Carta enumerada. 
Console.WriteLine("====CARTA====");

int numeracion = 1;

foreach (Producto producto in carta)
{
    Console.WriteLine($"{numeracion}. {producto.Nombre} - {producto.Precio:C}");
    numeracion++;
}

// Ejercicio 4: Filtrado por tipo.
Console.WriteLine("====BEBIDAS====");

int numeracion2 = 1;

foreach (Producto producto in carta)
{
    if (producto is Bebida)
    {
        Console.WriteLine($"{numeracion2}. {producto.Nombre} - {producto.Precio:C}");
        numeracion2++;
    }
}

// Ejercicio 5: Polimorfismo.
Producto producto1 = new Bebida("Agua", 2m, false);
Producto producto2 = new Postre("Flan", 4m, 300, true);
Producto producto3 = new Entrante("Nachos", 7m, 3, false);

producto1.MostrarDetalles();
producto2.MostrarDetalles();
producto3.MostrarDetalles();
*/