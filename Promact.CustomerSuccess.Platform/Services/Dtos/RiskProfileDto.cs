﻿using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class RiskProfileDto : AuditedEntityDto<Guid>
    {
        public Guid ProjectId { get; set; }
        public RiskType RiskType { get; set; }
        public string Description { get; set; }
        public RiskSeverity Severity { get; set; }
        public RiskImpact Impact { get; set; }
        public string RemedialSteps { get; set; }
        public string Status { get; set; }
        public DateTime ClosureDate { get; set; }
    }
}
