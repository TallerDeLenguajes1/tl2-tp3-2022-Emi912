public enum Estado
{
    EnCamino,
    Entregado,
    Cancelado
}
public class Pedido
{
    public int Nro { get; set; }
    public string Observacion { get; set; }
    public Cliente Cliente { get; set; }
    public Estado Estado { get; set; }
    
    public Pedido(string observacion, Cliente cliente)
    {
        this.Nro = HelperArchivos.GetLastPedido();
        this.Estado = 0;
        this.Observacion = observacion;
        this.Cliente = cliente;
    }
}