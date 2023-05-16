using Entekhab.Applications.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace Entekhab.Endpoints.WebApi.Controllers.Dtos
{

    public class UpdatePersonInfoModel  
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Allowance { get; set; }
        public decimal Transportation { get; set; }
        public decimal Tax { get; set; }

        internal UpdatePersonInfoCommand ToCommand()
        {
            return new UpdatePersonInfoCommand
            {
                Id = Id,
                Name = Name,
                Family = Family,
                Date = Date,
                BasicSalary = BasicSalary,
                Allowance = Allowance,
                Transportation = Transportation,
                Tax = Tax
                
            };
        }

    }
}
