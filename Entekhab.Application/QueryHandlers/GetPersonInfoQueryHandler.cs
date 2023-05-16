using Entekhab.Applications.Queries;
using Entekhab.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entekhab.Applications.QueryHandlers
{
    public class GetPersonInfoQueryHandler : IRequestHandler<GetPersonInfoQuery, GetPersonInfoQueryResult>
    {
        private readonly IPersonInfoReadRepository _repository;

        public GetPersonInfoQueryHandler(IPersonInfoReadRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetPersonInfoQueryResult> Handle(GetPersonInfoQuery request, CancellationToken cancellationToken)
        {
            var personInfo =await _repository.GetAsync(request.Id);

            GetPersonInfoQueryResult result = new GetPersonInfoQueryResult()
            { 
                Allowance= personInfo.Allowance,
                BasicSalary= personInfo.BasicSalary,
                Date=personInfo.Date,
                Family=personInfo.Family,
                Id=personInfo.Id,
                Name=personInfo.Name,
                SalaryAfterTax=personInfo.SalaryAfterTax,
                Transportation=personInfo.Transportation,
                
            };
            return result;


        }
    }
}
