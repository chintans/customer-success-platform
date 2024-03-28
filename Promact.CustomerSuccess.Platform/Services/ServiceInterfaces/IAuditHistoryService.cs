﻿using Promact.CustomerSuccess.Platform.Services.Dtos.CreateDto;
using Promact.CustomerSuccess.Platform.Services.Dtos.DbDto;
using Promact.CustomerSuccess.Platform.Services.Dtos.UpdateDto;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Promact.CustomerSuccess.Platform.Services.ServiceInterface
{
    public interface IAuditHistoryService : IApplicationService
    {
        Task CreateAuditHistoryAsync(CreateAuditHistoryDto newAudit);
        Task<ListResultDto<AuditHistoryDto>> GetAuditHistoryByProjectId(string projectId);
        Task UpdateAuditHistoryAsync(Guid id, UpdateAuditHistoryDto updatedAudit);
        Task DeleteAuditHistoryAsync(Guid id);
    }
}
