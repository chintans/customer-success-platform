﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class CreateDocumentVersionDto
    {
        [Required]
        public Guid ProjectId { get; set; }
        public ChangeType ChangeType { get; set; }

        public string Changes { get; set; }

        public string ChangeReason { get; set; }

     
    }
}
