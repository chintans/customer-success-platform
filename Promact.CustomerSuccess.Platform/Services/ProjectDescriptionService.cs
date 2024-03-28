﻿using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services
{
    public class ProjectDescriptionService : 
        CrudAppService<ProjectDescription,
        ProjectDescriptionDto,
        Guid,
        PagedAndSortedResultRequestDto,
        UpdateProjectDescriptionDto,
        CreateProjectDescriptionDto>,
        IProjectService
    {
        public ProjectDescriptionService(IRepository<ProjectDescription, Guid> repository) : base(repository)
        {
        }
    }
}

