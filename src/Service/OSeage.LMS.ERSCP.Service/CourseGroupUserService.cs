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
/// 课程小组用户表
///</summary>
    public class CourseGroupUserService
    {
    public ICourseGroupUserRepository CourseGroupUserRepository { get; }

    public CourseGroupUserService (ICourseGroupUserRepository courseGroupUserRepository)
    {
    CourseGroupUserRepository = courseGroupUserRepository;
    }

    public int Insert(CourseGroupUser courseGroupUser)
    {
    return CourseGroupUserRepository.Insert(courseGroupUser);
    }

    public int DeleteById(long id)
    {
    return  CourseGroupUserRepository.DeleteById(id);
    }

    public int Update(CourseGroupUser courseGroupUser)
    {
    return  CourseGroupUserRepository.Update(courseGroupUser);
    }

    }
    }

