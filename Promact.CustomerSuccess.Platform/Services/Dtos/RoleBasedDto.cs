using Promact.CustomerSuccess.Platform.Entities;
using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class RoleBasedDto : IEntityDto<Guid>
    {
        public Guid ProjectId { get; set; }
        public Guid Id { get; set ; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public RoleType role { get; set; }
    }
}
