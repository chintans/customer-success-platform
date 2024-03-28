﻿using Promact.CustomerSuccess.Platform.Services.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Promact.CustomerSuccess.Platform.Services
{
    public interface IAuditHistoryService : ICrudAppService<
        AuditHistoryDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateAuditHistoryDto,
        UpdateAuditHistoryDto>
    {
    }
}
