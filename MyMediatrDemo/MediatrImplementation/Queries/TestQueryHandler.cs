using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MediatrInfrastructure.Models;

namespace MediatrInfrastructure.Handlers.Queries
{
    public class TestQueryHandler : IRequestHandler<TestQuery, TestQueryResult>
    {
        public async Task<TestQueryResult> Handle(TestQuery request, CancellationToken cancellationToken)
        {
            await Task.Delay(100);
            var result = new TestQueryResult()
            {
                Id = 1,
                Name = "Dra"
            };

            return result;
        }
    }
}
