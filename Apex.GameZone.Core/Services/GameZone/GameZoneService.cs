﻿using Apex.GameZone.Core.Models;
using Apex.GameZone.Core.Services.Common;
using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Repositories.UoW;
using AutoMapper;

namespace Apex.GameZone.Core.Services.GameZone;

internal class GameZoneService : CommonService<GameZoneModel, GameZoneEntity>, IGameZoneService
{
    public GameZoneService(IUnitOfWork uow,
        IMapper mapper) : base(uow, mapper)
    {
    }
}