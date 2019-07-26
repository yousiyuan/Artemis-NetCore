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
/// 课程章节表
///</summary>
    public class CourseModelService
    {
    public ICourseModelRepository CourseModelRepository { get; }

    public CourseModelService (ICourseModelRepository courseModelRepository)
    {
    CourseModelRepository = courseModelRepository;
    }

    public int Insert(CourseModel courseModel)
    {
    return CourseModelRepository.Insert(courseModel);
    }

    public int DeleteById(long id)
    {
    return  CourseModelRepository.DeleteById(id);
    }

    public int Update(CourseModel courseModel)
    {
    return  CourseModelRepository.Update(courseModel);
    }

    }
    }

