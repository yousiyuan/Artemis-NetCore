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

