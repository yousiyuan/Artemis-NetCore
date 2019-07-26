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
/// 学院表
///</summary>
    public class CollegeService
    {
    public ICollegeRepository CollegeRepository { get; }

    public CollegeService (ICollegeRepository collegeRepository)
    {
    CollegeRepository = collegeRepository;
    }

    public int Insert(College college)
    {
    return CollegeRepository.Insert(college);
    }

    public int DeleteById(long id)
    {
    return  CollegeRepository.DeleteById(id);
    }

    public int Update(College college)
    {
    return  CollegeRepository.Update(college);
    }

    }
    }

