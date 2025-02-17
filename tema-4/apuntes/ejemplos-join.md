![[Pasted image 20250217192820.png]]


Obtener todos los pedidos con los datos del cliente asociado
```sql
SELECT Pedidos.PedidoID, Clientes.Nombre, Pedidos.FechaPedido, Pedidos.Total
FROM Pedidos
INNER JOIN Clientes ON Pedidos.ClienteID = Clientes.ClienteID;
```

Listar los productos que han sido pedidos junto con la cantidad y el nombre del cliente
```sql
SELECT Clientes.Nombre, Productos.NombreProducto, DetallesPedido.Cantidad
FROM DetallesPedido
INNER JOIN Pedidos ON DetallesPedido.PedidoID = Pedidos.PedidoID
INNER JOIN Clientes ON Pedidos.ClienteID = Clientes.ClienteID
INNER JOIN Productos ON DetallesPedido.ProductoID = Productos.ProductoID;
```

Mostrar los clientes que no han realizado pedidos:
```sql
SELECT Clientes.Nombre, Clientes.Email
FROM Clientes
LEFT JOIN Pedidos ON Clientes.ClienteID = Pedidos.ClienteID
WHERE Pedidos.PedidoID IS NULL;
```

Obtener el total gastado por cada cliente en pedidos
```sql
SELECT Clientes.Nombre, SUM(Pedidos.Total) AS TotalGastado
FROM Clientes
INNER JOIN Pedidos ON Clientes.ClienteID = Pedidos.ClienteID
GROUP BY Clientes.Nombre;
```

Listar todos los productos que nunca han sido comprados
```sql
SELECT Productos.NombreProducto, Productos.Precio
FROM Productos
LEFT JOIN DetallesPedido ON Productos.ProductoID = DetallesPedido.ProductoID
WHERE DetallesPedido.ProductoID IS NULL;
```
