namespace BlazorWebApp.Models
{
    public class Tenant
    {
        public int TenantId { get; set; }

        public string Name { get; set; }

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public bool isActive { get; set; }

    }
}
