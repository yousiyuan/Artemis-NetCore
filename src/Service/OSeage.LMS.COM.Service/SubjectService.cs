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
/// 学科表
///</summary>
    public class SubjectService
    {
    public ISubjectRepository SubjectRepository { get; }

    public SubjectService (ISubjectRepository subjectRepository)
    {
    SubjectRepository = subjectRepository;
    }

    public int Insert(Subject subject)
    {
    return SubjectRepository.Insert(subject);
    }

    public int DeleteById(long id)
    {
    return  SubjectRepository.DeleteById(id);
    }

    public int Update(Subject subject)
    {
    return  SubjectRepository.Update(subject);
    }

    }
    }

