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
/// 权限菜单表
///</summary>
    public class PopedomService
    {
    public IPopedomRepository PopedomRepository { get; }

    public PopedomService (IPopedomRepository popedomRepository)
    {
    PopedomRepository = popedomRepository;
    }

    public int Insert(Popedom popedom)
    {
    return PopedomRepository.Insert(popedom);
    }

    public int DeleteById(long id)
    {
    return  PopedomRepository.DeleteById(id);
    }

    public int Update(Popedom popedom)
    {
    return  PopedomRepository.Update(popedom);
    }

    }
    }

