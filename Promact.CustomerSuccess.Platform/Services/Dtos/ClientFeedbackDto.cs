﻿using System;
using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class ClientFeedbackDto : EntityDto<Guid>
    {
        public Guid ProjectId { get; set; }
        public DateTime FeedbackDate { get; set; }
        public FeedbackType FeedbackType { get; set; }
        public string Details { get; set; }
        public string ActionTaken { get; set; }
        public DateTime ClosureDate { get; set; }
    }
}
