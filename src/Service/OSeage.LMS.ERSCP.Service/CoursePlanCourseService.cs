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
/// 开课计划课程表
///</summary>
    public class CoursePlanCourseService
    {
    public ICoursePlanCourseRepository CoursePlanCourseRepository { get; }

    public CoursePlanCourseService (ICoursePlanCourseRepository coursePlanCourseRepository)
    {
    CoursePlanCourseRepository = coursePlanCourseRepository;
    }

    public int Insert(CoursePlanCourse coursePlanCourse)
    {
    return CoursePlanCourseRepository.Insert(coursePlanCourse);
    }

    public int DeleteById(long id)
    {
    return  CoursePlanCourseRepository.DeleteById(id);
    }

    public int Update(CoursePlanCourse coursePlanCourse)
    {
    return  CoursePlanCourseRepository.Update(coursePlanCourse);
    }

    }
    }

