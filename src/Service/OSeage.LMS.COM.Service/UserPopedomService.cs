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
/// 用户权限表
///</summary>
    public class UserPopedomService
    {
    public IUserPopedomRepository UserPopedomRepository { get; }

    public UserPopedomService (IUserPopedomRepository userPopedomRepository)
    {
    UserPopedomRepository = userPopedomRepository;
    }

    public int Insert(UserPopedom userPopedom)
    {
    return UserPopedomRepository.Insert(userPopedom);
    }

    public int DeleteById(long id)
    {
    return  UserPopedomRepository.DeleteById(id);
    }

    public int Update(UserPopedom userPopedom)
    {
    return  UserPopedomRepository.Update(userPopedom);
    }

    }
    }

