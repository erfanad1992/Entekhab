using Entekhab.Applications.Queries;
using Entekhab.Domain;
using Entekhab.Infrastructure.EfPersistance;
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
        private readonly EntekhabQueriesDbContext dbocntex;


        public GetPersonInfoQueryHandler(IPersonInfoReadRepository repository, EntekhabQueriesDbContext dbocntex)
        {
            _repository = repository;
            this.dbocntex = dbocntex;
        }
        public async Task<GetPersonInfoQueryResult> Handle(GetPersonInfoQuery request, CancellationToken cancellationToken)
        {
            int targetTrackingCode = 1;
            //var residMojavezPairs = dbocntex.Resids
            //     .Join(
            //         dbocntex.Mojavezes,
            //         r => r.TrackingCode,
            //         m => m.TrackingCode,
            //         (r, m) => new { r.ResidId, m.MojavezId })
            //     .GroupBy(pair => pair.ResidId)
            //     .ToDictionary(
            //         group => group.Key,
            //         group => group.Select(pair => pair.MojavezId)
            //         .ToList());
            var residMojavezPairs = dbocntex.Resids
              .Join(
                  dbocntex.Mojavezes,
                  r => r.TrackingCode,
                  m => m.TrackingCode,
                  (r, m) => new { r.ResidId, MojavezId = m.MojavezId })
              .GroupBy(pair => pair.ResidId)
              .ToList();

            foreach (var group in residMojavezPairs)
            {
                var residId = group.Key;
                var resId = dbocntex.Resids.Find(residId);
                resId.Mojavezes = new List<Mojavez>();

                if (resId != null)
                {
                    foreach (var pair in group)
                    {
                        var mojavez = dbocntex.Mojavezes.Find(pair.MojavezId);
                        mojavez.Resids = new List<Resid>();
                        if (mojavez!=null)
                        {
                            resId.Mojavezes.Add(mojavez);
                            mojavez.Resids.Add(resId);
                        }
            
                    }
         
                }

            }

            foreach (var trackingCode in residMojavezPairs)
            {
                Console.WriteLine(trackingCode);
            }

            //   var residds = from res in dbocntex.Resids 

            var mojavezes = dbocntex.Mojavezes.ToList();

            //List<ResidMojavez> junc = new List<Domain.ResidMojavez>();
            //foreach (var resid in resids)
            //{
                
            //    foreach (var mojavez in mojavezes)
            //    {

            //    }
            //}

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
