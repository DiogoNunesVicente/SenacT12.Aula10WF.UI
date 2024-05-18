namespace WinFormsApp1
{
    public class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public decimal ValorTotal { get; set; }
        public string FormaPagamento { get; set; }
        public string Status { get; set; }

    }
}