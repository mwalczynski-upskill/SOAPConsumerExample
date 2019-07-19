namespace SOAPClient
{
    using System;
    using System.Threading.Tasks;
    using CalculatorClient;

    class Program
    {
        static async Task Main(string[] args)
        {
            var x = 14;
            var y = 7;

            var client = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap12);

            Console.WriteLine($"{x} + {y} == {await client.AddAsync(x, y)}");
            Console.WriteLine($"{x} - {y} == {await client.SubtractAsync(x, y)}");
            Console.WriteLine($"{x} * {y} == {await client.MultiplyAsync(x, y)}");
            Console.WriteLine($"{x} / {y} == {await client.DivideAsync(x, y)}");

            await client.CloseAsync();

            Console.ReadKey();
        }
    }
}
