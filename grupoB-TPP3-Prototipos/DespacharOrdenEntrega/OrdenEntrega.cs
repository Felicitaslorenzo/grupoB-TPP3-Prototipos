namespace grupoB_TPP3_Prototipos.DespacharOrdenEntrega
{
    public class OrdenEntrega
    {
        public string IdOrden { get; set; }
        public string IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public OrdenEntrega(string idOrden, string idCliente, DateTime fecha, string estado)
        {
            IdOrden = idOrden;
            IdCliente = idCliente;
            Fecha = fecha;
            Estado = estado;
        }
    }
}
