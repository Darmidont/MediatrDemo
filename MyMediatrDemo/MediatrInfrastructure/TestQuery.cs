using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatrInfrastructure.Models
{
    public class TestQuery : IRequest<TestQueryResult>
    {
    }
}
