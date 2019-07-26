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
/// 用户角色表
///</summary>
    public class UserRoleService
    {
    public IUserRoleRepository UserRoleRepository { get; }

    public UserRoleService (IUserRoleRepository userRoleRepository)
    {
    UserRoleRepository = userRoleRepository;
    }

    public int Insert(UserRole userRole)
    {
    return UserRoleRepository.Insert(userRole);
    }

    public int DeleteById(long id)
    {
    return  UserRoleRepository.DeleteById(id);
    }

    public int Update(UserRole userRole)
    {
    return  UserRoleRepository.Update(userRole);
    }

    }
    }

