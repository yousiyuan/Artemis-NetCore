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
/// 年度专业表
///</summary>
    public class YearSpecialtyService
    {
    public IYearSpecialtyRepository YearSpecialtyRepository { get; }

    public YearSpecialtyService (IYearSpecialtyRepository yearSpecialtyRepository)
    {
    YearSpecialtyRepository = yearSpecialtyRepository;
    }

    public int Insert(YearSpecialty yearSpecialty)
    {
    return YearSpecialtyRepository.Insert(yearSpecialty);
    }

    public int DeleteById(long id)
    {
    return  YearSpecialtyRepository.DeleteById(id);
    }

    public int Update(YearSpecialty yearSpecialty)
    {
    return  YearSpecialtyRepository.Update(yearSpecialty);
    }

    }
    }

