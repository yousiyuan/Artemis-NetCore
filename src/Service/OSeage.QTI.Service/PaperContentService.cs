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
/// 试卷内容表
///</summary>
    public class PaperContentService
    {
    public IPaperContentRepository PaperContentRepository { get; }

    public PaperContentService (IPaperContentRepository paperContentRepository)
    {
    PaperContentRepository = paperContentRepository;
    }

    public int Insert(PaperContent paperContent)
    {
    return PaperContentRepository.Insert(paperContent);
    }

    public int DeleteById(long id)
    {
    return  PaperContentRepository.DeleteById(id);
    }

    public int Update(PaperContent paperContent)
    {
    return  PaperContentRepository.Update(paperContent);
    }

    }
    }

