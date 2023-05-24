namespace STgenetics.Models
{
    public class PedidoViewModel
    {
        public List<Animal> AnimalesSeleccionados { get; set; }
        public decimal TotalCompra { get; set; }
        public decimal DescuentoAnimal { get; set; }
        public decimal DescuentoAdicional { get; set; }
        public decimal Envio { get; set; }
        public decimal TotalPedido { get; set; }
    }
}
