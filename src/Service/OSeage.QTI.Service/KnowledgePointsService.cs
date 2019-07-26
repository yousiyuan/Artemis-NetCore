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
/// 知识点
///</summary>
    public class KnowledgePointsService
    {
    public IKnowledgePointsRepository KnowledgePointsRepository { get; }

    public KnowledgePointsService (IKnowledgePointsRepository knowledgePointsRepository)
    {
    KnowledgePointsRepository = knowledgePointsRepository;
    }

    public int Insert(KnowledgePoints knowledgePoints)
    {
    return KnowledgePointsRepository.Insert(knowledgePoints);
    }

    public int DeleteById(long id)
    {
    return  KnowledgePointsRepository.DeleteById(id);
    }

    public int Update(KnowledgePoints knowledgePoints)
    {
    return  KnowledgePointsRepository.Update(knowledgePoints);
    }

    }
    }

