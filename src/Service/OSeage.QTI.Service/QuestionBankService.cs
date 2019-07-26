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
/// 题库表
///</summary>
    public class QuestionBankService
    {
    public IQuestionBankRepository QuestionBankRepository { get; }

    public QuestionBankService (IQuestionBankRepository questionBankRepository)
    {
    QuestionBankRepository = questionBankRepository;
    }

    public int Insert(QuestionBank questionBank)
    {
    return QuestionBankRepository.Insert(questionBank);
    }

    public int DeleteById(long id)
    {
    return  QuestionBankRepository.DeleteById(id);
    }

    public int Update(QuestionBank questionBank)
    {
    return  QuestionBankRepository.Update(questionBank);
    }

    }
    }

