using grupoB_TPP3_Prototipos.Almacenes;
using grupoB_TPP3_Prototipos.ListarOrdenPreparacion;

namespace grupoB_TPP3_Prototipos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Cargar los datos desde almacenes aca:
            ClienteAlmacen.Leer();
            ProductoAlmacen.Leer();
            OrdenEntregaAlmacen.Leer();
            OrdenPreparacionAlmacen.Leer();
            OrdenSeleccionAlmacen.Leer();
            TransportistaAlmacen.Leer();

            Application.Run(new MenuPrincipal.MenuPrincipalForm());

            //Grabar los datos desde almacenes aca:
            ClienteAlmacen.Grabar();
            ProductoAlmacen.Grabar();
            OrdenEntregaAlmacen.Grabar();
            OrdenPreparacionAlmacen.Grabar();
            OrdenSeleccionAlmacen.Grabar();
            TransportistaAlmacen.Grabar();
        }
    }
}