namespace grupoB_TPP3_Prototipos.GenerarOrdenSeleccion;

internal class Cliente
{
    public string IdCliente { get; set; }
    public string nombreCliente { get; set; } 
    public List<string> Transportistas { get; set; }
    public List<Producto> Productos { get; set; }
}