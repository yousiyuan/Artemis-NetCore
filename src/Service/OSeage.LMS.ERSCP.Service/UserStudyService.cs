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
/// 用户学习表
///</summary>
    public class UserStudyService
    {
    public IUserStudyRepository UserStudyRepository { get; }

    public UserStudyService (IUserStudyRepository userStudyRepository)
    {
    UserStudyRepository = userStudyRepository;
    }

    public int Insert(UserStudy userStudy)
    {
    return UserStudyRepository.Insert(userStudy);
    }

    public int DeleteById(long id)
    {
    return  UserStudyRepository.DeleteById(id);
    }

    public int Update(UserStudy userStudy)
    {
    return  UserStudyRepository.Update(userStudy);
    }

    }
    }

