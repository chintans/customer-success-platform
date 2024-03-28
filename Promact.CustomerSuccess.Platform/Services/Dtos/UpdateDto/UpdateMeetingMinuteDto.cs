﻿using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.UpdateDto
{
    public class UpdateMeetingMinuteDto
    {
        public DateTime? MeetingDate { get; set; }
        public int? DurationInMinutes { get; set; }
        public string? MoMLink { get; set; }
        public string? Comments { get; set; }

        public Guid? ProjectId { get; set; }
    }
}