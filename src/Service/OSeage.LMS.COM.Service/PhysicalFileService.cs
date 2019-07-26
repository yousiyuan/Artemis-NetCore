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
/// 物理文件
///</summary>
    public class PhysicalFileService
    {
    public IPhysicalFileRepository PhysicalFileRepository { get; }

    public PhysicalFileService (IPhysicalFileRepository physicalFileRepository)
    {
    PhysicalFileRepository = physicalFileRepository;
    }

    public int Insert(PhysicalFile physicalFile)
    {
    return PhysicalFileRepository.Insert(physicalFile);
    }

    public int DeleteById(long id)
    {
    return  PhysicalFileRepository.DeleteById(id);
    }

    public int Update(PhysicalFile physicalFile)
    {
    return  PhysicalFileRepository.Update(physicalFile);
    }

    }
    }

