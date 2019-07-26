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
/// 试题与知识点关系表
///</summary>
    public class QuestionRefKnowledgeService
    {
    public IQuestionRefKnowledgeRepository QuestionRefKnowledgeRepository { get; }

    public QuestionRefKnowledgeService (IQuestionRefKnowledgeRepository questionRefKnowledgeRepository)
    {
    QuestionRefKnowledgeRepository = questionRefKnowledgeRepository;
    }

    public int Insert(QuestionRefKnowledge questionRefKnowledge)
    {
    return QuestionRefKnowledgeRepository.Insert(questionRefKnowledge);
    }

    public int DeleteById(long id)
    {
    return  QuestionRefKnowledgeRepository.DeleteById(id);
    }

    public int Update(QuestionRefKnowledge questionRefKnowledge)
    {
    return  QuestionRefKnowledgeRepository.Update(questionRefKnowledge);
    }

    }
    }

