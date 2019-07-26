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
/// 答题答案表
///</summary>
    public class QuestionAnswerItemService
    {
    public IQuestionAnswerItemRepository QuestionAnswerItemRepository { get; }

    public QuestionAnswerItemService (IQuestionAnswerItemRepository questionAnswerItemRepository)
    {
    QuestionAnswerItemRepository = questionAnswerItemRepository;
    }

    public int Insert(QuestionAnswerItem questionAnswerItem)
    {
    return QuestionAnswerItemRepository.Insert(questionAnswerItem);
    }

    public int DeleteById(long id)
    {
    return  QuestionAnswerItemRepository.DeleteById(id);
    }

    public int Update(QuestionAnswerItem questionAnswerItem)
    {
    return  QuestionAnswerItemRepository.Update(questionAnswerItem);
    }

    }
    }

