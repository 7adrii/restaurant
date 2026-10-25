2. Carta del Restaurante.

- ¿Por qué una `List<Producto>` puede contener objetos de tipo `Bebida`, `Postre`, `PlatoPrincipal` o `Entrante`?
    Porque heredan de Producto y por eso se pueden tratar como tipo producto.

- ¿Qué relación existe entre estas clases y `Producto`?
    Es una relacion de herencia, Producto es la base de las que derivan las demas. Heredan nombre y precio ademas de añadir sus propios atributos.


4. Filtrado por Tipo.

- ¿Qué tipo tiene la variable utilizada para recorrer la `List<Producto>`?
    Tipo Producto y el foreach recorre la lista de productos y los va almacenando en la variable producto.

- ¿Puede esa variable contener un objeto cuyo tipo real sea `Bebida`?
    Si, La variable es Producto pero al objeto que hace referencia puede ser cualquiera que herede de el.

- ¿Qué permite comprobar el operador `is`?
    Permite comprobar si un objeto es de un tipo determinado o si hereda de ese tipo.


5. Polimorfismo.

- ¿Cuál es el tipo de la variable `producto1`?
    Producto

- ¿Cuál es el tipo real del objeto almacenado en `producto1`?
    Bebida

- ¿Qué implementación de `ObtenerDescripcion()` se ejecutará?
    La de la clase Bebida, ya que es el tipo real del objeto.

- ¿Qué ocurrirá con `producto2`?
    Lo mismo pero con Postre.

- ¿Qué ocurrirá con `producto3`?
    Lo mismo pero con Entrante.

- ¿Qué concepto de programación orientada a objetos permite este comportamiento?
    El Polimorfismo. Permite tratar objetos de distintas clases de forma uniforme partiendo de la base de Producto.