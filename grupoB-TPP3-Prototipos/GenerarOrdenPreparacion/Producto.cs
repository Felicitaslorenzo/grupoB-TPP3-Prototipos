namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion;

internal class Producto
{
    public string IDProducto { get; set; }
    public string DescripcionProducto { get; set; }
    public int Cantidad { get; set; }
    public string Ubicacion { get; set; }

    public override string ToString() => $"{IDProducto} - {DescripcionProducto}";
}