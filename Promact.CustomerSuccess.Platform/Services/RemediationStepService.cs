﻿using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;



namespace Promact.CustomerSuccess.Platform.Services
{
    public class RemediationStepService :
        CrudAppService<RemediationStep,
            RemediationStepDto,
            
            Guid,
            PagedAndSortedResultRequestDto,
            CreateRemediationStepDto,
            UpdateRemediationStepDto
            >,
        IRemediationStepService
    {
        public RemediationStepService(IRepository<RemediationStep, Guid> RemediationStepRepository) :
            base(RemediationStepRepository)
        {
        }
    }
}
