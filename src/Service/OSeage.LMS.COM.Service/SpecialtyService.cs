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
/// 专业表
///</summary>
    public class SpecialtyService
    {
    public ISpecialtyRepository SpecialtyRepository { get; }

    public SpecialtyService (ISpecialtyRepository specialtyRepository)
    {
    SpecialtyRepository = specialtyRepository;
    }

    public int Insert(Specialty specialty)
    {
    return SpecialtyRepository.Insert(specialty);
    }

    public int DeleteById(long id)
    {
    return  SpecialtyRepository.DeleteById(id);
    }

    public int Update(Specialty specialty)
    {
    return  SpecialtyRepository.Update(specialty);
    }

    }
    }

