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
/// 校区表
///</summary>
    public class CampusService
    {
    public ICampusRepository CampusRepository { get; }

    public CampusService (ICampusRepository campusRepository)
    {
    CampusRepository = campusRepository;
    }

    public int Insert(Campus campus)
    {
    return CampusRepository.Insert(campus);
    }

    public int DeleteById(long id)
    {
    return  CampusRepository.DeleteById(id);
    }

    public int Update(Campus campus)
    {
    return  CampusRepository.Update(campus);
    }

    }
    }

