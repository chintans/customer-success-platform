﻿using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.UpdateDto
{
    public class UpdateStakeholdersDto
    {
        public Guid? UserID { get; set; }
        public string? Title { get; set; }
        public string? Name { get; set; }
        public string? Contact { get; set; }

        public Guid? ProjectId { get; set; }
    }
}
