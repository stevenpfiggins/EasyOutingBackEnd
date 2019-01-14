﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Interests
{

    public interface IInterestsManager
    {
        Task<bool> CreateInterests(InterestsCreateDTO dto);
        Task<InterestsGetListItemDTO> GetInterests(int id);
        Task<bool> DeleteInterests(int id);
        Task<bool> UpdateInterests(InterestsUpdateDTO dto);

    }
}
