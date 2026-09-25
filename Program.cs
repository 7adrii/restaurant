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