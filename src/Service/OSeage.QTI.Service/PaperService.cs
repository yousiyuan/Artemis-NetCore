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
/// 试卷表
///</summary>
    public class PaperService
    {
    public IPaperRepository PaperRepository { get; }

    public PaperService (IPaperRepository paperRepository)
    {
    PaperRepository = paperRepository;
    }

    public int Insert(Paper paper)
    {
    return PaperRepository.Insert(paper);
    }

    public int DeleteById(long id)
    {
    return  PaperRepository.DeleteById(id);
    }

    public int Update(Paper paper)
    {
    return  PaperRepository.Update(paper);
    }

    }
    }

