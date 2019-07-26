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
/// 学校表
///</summary>
    public class SchoolService
    {
    public ISchoolRepository SchoolRepository { get; }

    public SchoolService (ISchoolRepository schoolRepository)
    {
    SchoolRepository = schoolRepository;
    }

    public int Insert(School school)
    {
    return SchoolRepository.Insert(school);
    }

    public int DeleteById(long id)
    {
    return  SchoolRepository.DeleteById(id);
    }

    public int Update(School school)
    {
    return  SchoolRepository.Update(school);
    }

    }
    }

