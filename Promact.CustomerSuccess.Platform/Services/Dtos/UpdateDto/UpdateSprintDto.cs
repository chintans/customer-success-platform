﻿using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.UpdateDto
{
    public class UpdateSprintDto
    {
        public int? SprintNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public SprintStatus? Status { get; set; }
        public string? Comments { get; set; }

        public Guid? ProjectId { get; set; }
    }
}
