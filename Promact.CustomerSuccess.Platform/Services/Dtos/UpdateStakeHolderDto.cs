﻿using Promact.CustomerSuccess.Platform.Entities;
using System.ComponentModel.DataAnnotations;

namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class UpdateStakeHolderDto
    {
        public Guid ProjectId { get; set; }
        public StakeHolderTitle Title { get; set; }
        public required string Name { get; set; }
        public required string Contact { get; set; }
    }
}
