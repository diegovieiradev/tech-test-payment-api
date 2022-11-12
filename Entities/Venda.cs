using PaymentAPI.Enums;

namespace PaymentAPI.Entities
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusVenda StatusVenda { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<Produto> ItensVendidos { get; set; }
    }
}
