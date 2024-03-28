﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class UpdateProjectResourcesDto
    {
        [Required]
        public Guid ProjectId { get; set; }

        [Required]
        public string ResourceName { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}
