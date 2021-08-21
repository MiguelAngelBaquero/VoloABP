namespace Orders
{
    public static class OrdersDbProperties
    {
        public static string DbTablePrefix { get; set; } = "";

        public static string DbSchema { get; set; } = "ord";

        public const string ConnectionStringName = "Orders";
    }
}
