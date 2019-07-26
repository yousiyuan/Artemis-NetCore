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
/// 考试题
///</summary>
    public class QuestionService
    {
    public IQuestionRepository QuestionRepository { get; }

    public QuestionService (IQuestionRepository questionRepository)
    {
    QuestionRepository = questionRepository;
    }

    public int Insert(Question question)
    {
    return QuestionRepository.Insert(question);
    }

    public int DeleteById(long id)
    {
    return  QuestionRepository.DeleteById(id);
    }

    public int Update(Question question)
    {
    return  QuestionRepository.Update(question);
    }

    }
    }

