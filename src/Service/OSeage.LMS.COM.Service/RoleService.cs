//*******************************
// Create By 流年 公子
// Date 2019-07-03 14:02
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Linq;
using OSeage.LMS.COM.Entity;
using OSeage.LMS.COM.Repository;

namespace OSeage.LMS.COM.Service
{
    ///<summary>
/// 角色表
///</summary>
    public class RoleService
    {
    public IRoleRepository RoleRepository { get; }

    public RoleService (IRoleRepository roleRepository)
    {
    RoleRepository = roleRepository;
    }

    public int Insert(Role role)
    {
    return RoleRepository.Insert(role);
    }

    public int DeleteById(long id)
    {
    return  RoleRepository.DeleteById(id);
    }

    public int Update(Role role)
    {
    return  RoleRepository.Update(role);
    }

    }
    }

