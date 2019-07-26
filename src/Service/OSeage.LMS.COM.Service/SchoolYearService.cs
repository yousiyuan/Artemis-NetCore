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
/// 学年学期表
///</summary>
    public class SchoolYearService
    {
    public ISchoolYearRepository SchoolYearRepository { get; }

    public SchoolYearService (ISchoolYearRepository schoolYearRepository)
    {
    SchoolYearRepository = schoolYearRepository;
    }

    public int Insert(SchoolYear schoolYear)
    {
    return SchoolYearRepository.Insert(schoolYear);
    }

    public int DeleteById(long id)
    {
    return  SchoolYearRepository.DeleteById(id);
    }

    public int Update(SchoolYear schoolYear)
    {
    return  SchoolYearRepository.Update(schoolYear);
    }

    }
    }

