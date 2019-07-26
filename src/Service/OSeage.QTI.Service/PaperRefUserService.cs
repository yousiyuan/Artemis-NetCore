//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:49
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Linq;
using OSeage.QTI.Entity;
using OSeage.QTI.Repository;

namespace OSeage.QTI.Service
{
    ///<summary>
/// 试卷与用户关系表
///</summary>
    public class PaperRefUserService
    {
    public IPaperRefUserRepository PaperRefUserRepository { get; }

    public PaperRefUserService (IPaperRefUserRepository paperRefUserRepository)
    {
    PaperRefUserRepository = paperRefUserRepository;
    }

    public int Insert(PaperRefUser paperRefUser)
    {
    return PaperRefUserRepository.Insert(paperRefUser);
    }

    public int DeleteById(long id)
    {
    return  PaperRefUserRepository.DeleteById(id);
    }

    public int Update(PaperRefUser paperRefUser)
    {
    return  PaperRefUserRepository.Update(paperRefUser);
    }

    }
    }

