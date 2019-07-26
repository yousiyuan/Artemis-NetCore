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
/// 开课计划学生表
///</summary>
    public class CoursePlanStudentService
    {
    public ICoursePlanStudentRepository CoursePlanStudentRepository { get; }

    public CoursePlanStudentService (ICoursePlanStudentRepository coursePlanStudentRepository)
    {
    CoursePlanStudentRepository = coursePlanStudentRepository;
    }

    public int Insert(CoursePlanStudent coursePlanStudent)
    {
    return CoursePlanStudentRepository.Insert(coursePlanStudent);
    }

    public int DeleteById(long id)
    {
    return  CoursePlanStudentRepository.DeleteById(id);
    }

    public int Update(CoursePlanStudent coursePlanStudent)
    {
    return  CoursePlanStudentRepository.Update(coursePlanStudent);
    }

    }
    }

