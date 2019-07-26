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
/// 试题与标签关系表
///</summary>
    public class QuestionRefTagService
    {
    public IQuestionRefTagRepository QuestionRefTagRepository { get; }

    public QuestionRefTagService (IQuestionRefTagRepository questionRefTagRepository)
    {
    QuestionRefTagRepository = questionRefTagRepository;
    }

    public int Insert(QuestionRefTag questionRefTag)
    {
    return QuestionRefTagRepository.Insert(questionRefTag);
    }

    public int DeleteById(long id)
    {
    return  QuestionRefTagRepository.DeleteById(id);
    }

    public int Update(QuestionRefTag questionRefTag)
    {
    return  QuestionRefTagRepository.Update(questionRefTag);
    }

    }
    }

