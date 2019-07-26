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
/// 班级表
///</summary>
    public class ClassService
    {
    public IClassRepository ClassRepository { get; }

    public ClassService (IClassRepository classRepository)
    {
    ClassRepository = classRepository;
    }

    public int Insert(Class clazz)
    {
    return ClassRepository.Insert(clazz);
    }

    public int DeleteById(long id)
    {
    return  ClassRepository.DeleteById(id);
    }

    public int Update(Class clazz)
    {
    return  ClassRepository.Update(clazz);
    }

    }
    }

