﻿using Promact.CustomerSuccess.Platform.Services.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Promact.CustomerSuccess.Platform.Services
{
    public interface IRiskProfileService : ICrudAppService<
        RiskProfileDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateRiskProfileDto,
        UpdateRiskProfileDto>
    {
    }
}
