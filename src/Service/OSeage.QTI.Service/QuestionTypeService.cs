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
/// 题型表
///</summary>
    public class QuestionTypeService
    {
    public IQuestionTypeRepository QuestionTypeRepository { get; }

    public QuestionTypeService (IQuestionTypeRepository questionTypeRepository)
    {
    QuestionTypeRepository = questionTypeRepository;
    }

    public int Insert(QuestionType questionType)
    {
    return QuestionTypeRepository.Insert(questionType);
    }

    public int DeleteById(long id)
    {
    return  QuestionTypeRepository.DeleteById(id);
    }

    public int Update(QuestionType questionType)
    {
    return  QuestionTypeRepository.Update(questionType);
    }

    }
    }

