namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion;

internal class Cliente
{
    public string IdCliente { get; set; }
    public string Prioridad { get; set; }
    public string Transportista { get; set; }
    public List<Producto> Productos { get; set; }
}