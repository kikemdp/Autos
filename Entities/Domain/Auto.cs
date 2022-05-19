namespace Entities.Domain
{
    public class Auto : Tenant
    {
        public int AutoID { get; set; }
        public string Modelo { get; set; }

        public double Precio { get; set; }
        public int Anio { get; set; }
    }
}
