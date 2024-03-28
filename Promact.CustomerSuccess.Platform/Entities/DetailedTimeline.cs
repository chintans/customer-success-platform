﻿using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class DetailedTimeline : AuditedEntity<Guid>
    {
        [ForeignKey("Project")]
        public Guid ProjectId { get; set; }
        public virtual Project? Project { get; set; }
        public string Link { get; set; }

    }
}
