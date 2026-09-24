using Models;

PlatoPrincipal plato = new PlatoPrincipal("Plato Combinado", 12.50m, "Pollo, patatas, pimientos");
plato.MostrarDetalles();

Bebida bebida = new Bebida("CocaCola", 8.5m, true);
bebida.MostrarDetalles();

Postre postre = new Postre("Tarta de queso", 12.45m, 300, false);
postre.MostrarDetalles();