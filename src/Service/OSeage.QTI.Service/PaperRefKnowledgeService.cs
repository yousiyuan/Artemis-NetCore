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
/// 试卷与知识点关系表
///</summary>
    public class PaperRefKnowledgeService
    {
    public IPaperRefKnowledgeRepository PaperRefKnowledgeRepository { get; }

    public PaperRefKnowledgeService (IPaperRefKnowledgeRepository paperRefKnowledgeRepository)
    {
    PaperRefKnowledgeRepository = paperRefKnowledgeRepository;
    }

    public int Insert(PaperRefKnowledge paperRefKnowledge)
    {
    return PaperRefKnowledgeRepository.Insert(paperRefKnowledge);
    }

    public int DeleteById(long id)
    {
    return  PaperRefKnowledgeRepository.DeleteById(id);
    }

    public int Update(PaperRefKnowledge paperRefKnowledge)
    {
    return  PaperRefKnowledgeRepository.Update(paperRefKnowledge);
    }

    }
    }

