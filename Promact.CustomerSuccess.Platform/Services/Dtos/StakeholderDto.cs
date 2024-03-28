﻿using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class StakeholderDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public StakeholderTitle Title { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}
