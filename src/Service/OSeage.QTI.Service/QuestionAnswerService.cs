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
/// 答题记录表
///</summary>
    public class QuestionAnswerService
    {
    public IQuestionAnswerRepository QuestionAnswerRepository { get; }

    public QuestionAnswerService (IQuestionAnswerRepository questionAnswerRepository)
    {
    QuestionAnswerRepository = questionAnswerRepository;
    }

    public int Insert(QuestionAnswer questionAnswer)
    {
    return QuestionAnswerRepository.Insert(questionAnswer);
    }

    public int DeleteById(long id)
    {
    return  QuestionAnswerRepository.DeleteById(id);
    }

    public int Update(QuestionAnswer questionAnswer)
    {
    return  QuestionAnswerRepository.Update(questionAnswer);
    }

    }
    }

