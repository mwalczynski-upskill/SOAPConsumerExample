namespace SOAPClient.Manually
{
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.Threading.Tasks;

    public class CalculatorServiceClient : ClientBase<ICalculatorService>
    {
        public CalculatorServiceClient(Binding binding, EndpointAddress address) : base(binding, address)
        {
        }

        public async Task<int> AddAsync(int x, int y) => await Channel.AddAsync(x, y);
        public async Task<int> SubtractAsync(int x, int y) => await Channel.SubtractAsync(x, y);
        public async Task<int> MultiplyAsync(int x, int y) => await Channel.MultiplyAsync(x, y);
        public async Task<int> DivideAsync(int x, int y) => await Channel.DivideAsync(x, y);
    }
}
