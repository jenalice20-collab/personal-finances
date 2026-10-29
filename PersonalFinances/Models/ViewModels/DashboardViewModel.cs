namespace PersonalFinances.Models.ViewModels
{
    public class DashboardViewModel
    {
        public decimal TotalBalance { get; set; }
        public decimal BalanceOnMonth { get; set; }
        public int Movements { get; set; }
        public int Accounts { get; set; }
    }
}