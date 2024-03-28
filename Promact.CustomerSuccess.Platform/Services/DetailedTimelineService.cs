﻿using AutoMapper;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services
{
    public class DetailedTimelineService :
        CrudAppService<
            DetailedTimeline,
            DetailedTimelineDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateDetailedTimelineDto,
            UpdateDetailedTimelineDto>,
        IDetailedTimelineService
    {
        public DetailedTimelineService(IRepository<DetailedTimeline, Guid> DetailedTimelinerepository)
            : base(DetailedTimelinerepository)
        {
        }
    }
}
