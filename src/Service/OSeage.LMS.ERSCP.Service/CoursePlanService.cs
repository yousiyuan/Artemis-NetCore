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
/// 开课计划表
///</summary>
    public class CoursePlanService
    {
    public ICoursePlanRepository CoursePlanRepository { get; }

    public CoursePlanService (ICoursePlanRepository coursePlanRepository)
    {
    CoursePlanRepository = coursePlanRepository;
    }

    public int Insert(CoursePlan coursePlan)
    {
    return CoursePlanRepository.Insert(coursePlan);
    }

    public int DeleteById(long id)
    {
    return  CoursePlanRepository.DeleteById(id);
    }

    public int Update(CoursePlan coursePlan)
    {
    return  CoursePlanRepository.Update(coursePlan);
    }

    }
    }

