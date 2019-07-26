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
/// Table, sysdiagrams
///</summary>
    public class SysdiagramsService
    {
    public ISysdiagramsRepository SysdiagramsRepository { get; }

    public SysdiagramsService (ISysdiagramsRepository sysdiagramsRepository)
    {
    SysdiagramsRepository = sysdiagramsRepository;
    }

    public string Insert(Sysdiagrams sysdiagrams)
    {
    return SysdiagramsRepository.Insert(sysdiagrams);
    }

    public int DeleteById(string id)
    {
    return  SysdiagramsRepository.DeleteById(id);
    }

    public int Update(Sysdiagrams sysdiagrams)
    {
    return  SysdiagramsRepository.Update(sysdiagrams);
    }

    }
    }

