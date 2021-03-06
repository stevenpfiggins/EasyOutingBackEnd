﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Outing.Interfaces;
using RedStarter.Database.DataContract.Outing.RAOs;
using RedStarter.Database.Entities.Outing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Outing
{
    public class OutingRepository : IOutingRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public OutingRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateOuting(OutingCreateRAO rao)
        {
            var entity = _mapper.Map<OutingEntity>(rao);

            await _context.OutingTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IEnumerable<OutingGetListItemRAO>> GetOutings()
        {
            var entity = await _context.OutingTableAccess.ToArrayAsync();
            var rao = _mapper.Map<IEnumerable<OutingGetListItemRAO>>(entity);

            return rao;
        }

        public async Task<IEnumerable<OutingGetListItemRAO>> GetOutingsByUser(int id)
        {
            var entity = await _context.OutingTableAccess.Where(e => e.OwnerId == id).ToArrayAsync();
            var rao = _mapper.Map<IEnumerable<OutingGetListItemRAO>>(entity);

            return rao;
        }

        public async Task<OutingGetByIdRAO> GetOutingById(int id)
        {
            var entity = await _context.OutingTableAccess.SingleAsync(e => e.OutingEntityId == id);
            var rao = _mapper.Map<OutingGetByIdRAO>(entity);

            return rao;
        }

        public async Task<bool> OutingUpdate(OutingUpdateRAO rao)
        {
            var entity = await _context
                .OutingTableAccess
                .SingleOrDefaultAsync(e => e.OutingEntityId == rao.OutingEntityId);

            entity.OutingName = rao.OutingName;
            entity.OutingDescription = rao.OutingDescription;
            entity.OutingDate = rao.OutingDate;
            entity.OutingLocation = rao.OutingLocation;
            entity.OutingType = rao.OutingType;
            entity.CreatedOn = rao.CreatedOn;

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteOuting(int id)
        {
            var entity = await _context.OutingTableAccess.SingleAsync(e => e.OutingEntityId == id);
            _context.OutingTableAccess.Remove(entity);

            return await _context.SaveChangesAsync() == 1;
        }
    }
}
