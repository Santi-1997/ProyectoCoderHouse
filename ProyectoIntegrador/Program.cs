namespace ProyectoIntegrador
{
    class Test
    {
        static void Main(string[] args)
        {
            ProductoHandler productoHandler = new ProductoHandler();

            var listaProducto = productoHandler.GetProductos();

            foreach (var producto in listaProducto)
            {
                Console.WriteLine(producto.GetDataProducto());
            }

            UsuarioHandler usuarioHandler = new UsuarioHandler();

            var listaUsuario = usuarioHandler.GetUsuarios();

            foreach (var usuario in listaUsuario)
            {
                Console.WriteLine(usuario.GetDataUsuario());
            }

            ProductoVendidoHandler productoVendidoHandler = new ProductoVendidoHandler();

            var listaProductoVendido = productoVendidoHandler.GetProductosVendidos();

            foreach (var productoVendido in listaProductoVendido)
            {
                Console.WriteLine(productoVendido.GetDataProductoVendido());
            }

            VentaHandler ventaHandler = new VentaHandler();

            var listaVenta = ventaHandler.GetVentas();

            foreach (var venta in listaVenta)
            {
                Console.WriteLine(venta.GetDataVenta());
            }




            SesionHandler sesionHandler = new SesionHandler();

            Console.WriteLine("Ingrese su nombre de usuario");

            var nombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña");

            var contraseña = Console.ReadLine();

            bool estaLogueado = sesionHandler.ValidarUsuario(nombreUsuario, contraseña);

            if (estaLogueado)
            {
                Console.WriteLine("Esta logueado");
            }
            else
            {
                Console.WriteLine("No esta logueado");

            }
        }
    }
}
