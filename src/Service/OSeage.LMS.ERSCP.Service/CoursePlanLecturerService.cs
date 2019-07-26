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
/// 开课计划讲师表
///</summary>
    public class CoursePlanLecturerService
    {
    public ICoursePlanLecturerRepository CoursePlanLecturerRepository { get; }

    public CoursePlanLecturerService (ICoursePlanLecturerRepository coursePlanLecturerRepository)
    {
    CoursePlanLecturerRepository = coursePlanLecturerRepository;
    }

    public int Insert(CoursePlanLecturer coursePlanLecturer)
    {
    return CoursePlanLecturerRepository.Insert(coursePlanLecturer);
    }

    public int DeleteById(long id)
    {
    return  CoursePlanLecturerRepository.DeleteById(id);
    }

    public int Update(CoursePlanLecturer coursePlanLecturer)
    {
    return  CoursePlanLecturerRepository.Update(coursePlanLecturer);
    }

    }
    }

