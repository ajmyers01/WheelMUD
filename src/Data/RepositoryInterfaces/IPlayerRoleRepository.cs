﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="IPlayerRoleRepository.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by RepositoryInterface.cst on 7/7/2012 4:24:09 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Entities
{
    using System.Collections.Generic;	
    
    ///<summary>
    /// Repository interface for the PlayerRole entity.
    ///</summary>
    public interface IPlayerRoleRepository
    {        
        void Add(PlayerRoleRecord playerrole);
        void Update(PlayerRoleRecord playerrole);
        void Remove(PlayerRoleRecord playerrole);
        PlayerRoleRecord GetById(long playerroleId);		
        PlayerRoleRecord GetByName(string name);
        ICollection<PlayerRoleRecord> FetchAll();
    }
}