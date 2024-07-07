namespace WebApplication2.ServicesLayer
{
    public class CalculationService : ICalculationService
    {
        public int SumTwoNumbers(int number1, int number2) {
            return number1 + number2;
                }
    }
}
