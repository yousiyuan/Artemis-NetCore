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
/// 试题预览记录表
///</summary>
    public class QuestionSetService
    {
    public IQuestionSetRepository QuestionSetRepository { get; }

    public QuestionSetService (IQuestionSetRepository questionSetRepository)
    {
    QuestionSetRepository = questionSetRepository;
    }

    public int Insert(QuestionSet questionSet)
    {
    return QuestionSetRepository.Insert(questionSet);
    }

    public int DeleteById(long id)
    {
    return  QuestionSetRepository.DeleteById(id);
    }

    public int Update(QuestionSet questionSet)
    {
    return  QuestionSetRepository.Update(questionSet);
    }

    }
    }

