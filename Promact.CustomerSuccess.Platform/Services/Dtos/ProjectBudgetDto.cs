
using Volo.Abp.Application.Dtos;
namespace Promact.CustomerSuccess.Platform.Dtos
{
    public class ProjectBudgetDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public ProjectType Type { get; set; }
        public int? DurationInMonths { get; set; }
        public int? ContractDuration { get; set; }
        public int? BudgetedHours { get; set; }
        public double BudgetedCost { get; set; }
        public string Currency { get; set; }
        public string Comment { get; set; }
    }
}
