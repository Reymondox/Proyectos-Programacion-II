namespace DRY_Principle.Clases
{
    public class CalculoDeSalario
    {
        private decimal CalcularSalarioTotal(decimal calculadoDelSalario)
        {
            decimal impuestos = calculadoDelSalario * 0.18m;
            decimal bonos = calculadoDelSalario * 0.05m;


            return calculadoDelSalario - impuestos + bonos;
        }
        public decimal CalcularSalarioPorHora(decimal salarioPorHora, int horasTrabajadas)
        {
            decimal calculadoDelSalario = salarioPorHora * horasTrabajadas;
            return CalcularSalarioTotal(calculadoDelSalario);
        }

        public decimal CalcularSalarioFijo(decimal salarioBase)
        {
            return CalcularSalarioTotal(salarioBase);
        }






    }
}