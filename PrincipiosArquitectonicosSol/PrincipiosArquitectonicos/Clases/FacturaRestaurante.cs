namespace KISSPrinciple.Clases
{
    public class FacturaRestaurante
    {
        public decimal CalcularFactura(decimal[] preciosPlatos, decimal? porcentajePropina)
        {
            decimal total = 0;
            for(int i = 0; i < preciosPlatos.Length; i++)
            {
                total = total + preciosPlatos[i];
            }

            if(porcentajePropina.HasValue)
            {
                total = total + (total * (porcentajePropina.Value / 100));
            }

            else
            {
                total = total + total * 0.10m;
            }

            return total;
        }
    }
}
