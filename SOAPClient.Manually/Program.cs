namespace SOAPClient.Manually
{
    using System;
    using System.ServiceModel;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main(string[] args)
        {
            var x = 14;
            var y = 7;

            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri("http://www.dneonline.com/calculator.asmx"));

            var client = new CalculatorServiceClient(binding, endpoint);

            Console.WriteLine($"{x} + {y} == {await client.AddAsync(x, y)}");
            Console.WriteLine($"{x} - {y} == {await client.SubtractAsync(x, y)}");
            Console.WriteLine($"{x} * {y} == {await client.MultiplyAsync(x, y)}");
            Console.WriteLine($"{x} / {y} == {await client.DivideAsync(x, y)}");

            client.Close();

            Console.ReadKey();
        }
    }
}
//http://www.dneonline.com/calculator.asmx