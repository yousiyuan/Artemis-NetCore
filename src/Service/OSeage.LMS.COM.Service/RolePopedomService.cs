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
/// 角色权限表
///</summary>
    public class RolePopedomService
    {
    public IRolePopedomRepository RolePopedomRepository { get; }

    public RolePopedomService (IRolePopedomRepository rolePopedomRepository)
    {
    RolePopedomRepository = rolePopedomRepository;
    }

    public int Insert(RolePopedom rolePopedom)
    {
    return RolePopedomRepository.Insert(rolePopedom);
    }

    public int DeleteById(long id)
    {
    return  RolePopedomRepository.DeleteById(id);
    }

    public int Update(RolePopedom rolePopedom)
    {
    return  RolePopedomRepository.Update(rolePopedom);
    }

    }
    }

