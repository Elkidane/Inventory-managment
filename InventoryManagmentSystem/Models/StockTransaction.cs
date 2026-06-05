namespace InventoryManagementSystem.Models
{
    public class StockTransaction
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public string TransactionType { get; set; }

        public int Quantity { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
