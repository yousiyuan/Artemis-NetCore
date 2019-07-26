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
/// 课程小组表
///</summary>
    public class CoursePlanGroupService
    {
    public ICoursePlanGroupRepository CoursePlanGroupRepository { get; }

    public CoursePlanGroupService (ICoursePlanGroupRepository coursePlanGroupRepository)
    {
    CoursePlanGroupRepository = coursePlanGroupRepository;
    }

    public int Insert(CoursePlanGroup coursePlanGroup)
    {
    return CoursePlanGroupRepository.Insert(coursePlanGroup);
    }

    public int DeleteById(long id)
    {
    return  CoursePlanGroupRepository.DeleteById(id);
    }

    public int Update(CoursePlanGroup coursePlanGroup)
    {
    return  CoursePlanGroupRepository.Update(coursePlanGroup);
    }

    }
    }

