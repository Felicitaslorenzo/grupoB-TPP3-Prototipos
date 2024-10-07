namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion;

internal class Producto
{
    public string ID { get; set; }
    public string Descripcion { get; set; }

    public override string ToString() => $"{ID} - {Descripcion}";
}