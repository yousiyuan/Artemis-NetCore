//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:57
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Linq;
using OSeage.LMS.ERSCP.Entity;
using OSeage.LMS.ERSCP.Repository;

namespace OSeage.LMS.ERSCP.Service
{
    ///<summary>
/// 开课计划班级表
///</summary>
    public class CoursePlanClassService
    {
    public ICoursePlanClassRepository CoursePlanClassRepository { get; }

    public CoursePlanClassService (ICoursePlanClassRepository coursePlanClassRepository)
    {
    CoursePlanClassRepository = coursePlanClassRepository;
    }

    public int Insert(CoursePlanClass coursePlanClass)
    {
    return CoursePlanClassRepository.Insert(coursePlanClass);
    }

    public int DeleteById(long id)
    {
    return  CoursePlanClassRepository.DeleteById(id);
    }

    public int Update(CoursePlanClass coursePlanClass)
    {
    return  CoursePlanClassRepository.Update(coursePlanClass);
    }

    }
    }

