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
/// 考试答案记录表
///</summary>
    public class PaperAnswerService
    {
    public IPaperAnswerRepository PaperAnswerRepository { get; }

    public PaperAnswerService (IPaperAnswerRepository paperAnswerRepository)
    {
    PaperAnswerRepository = paperAnswerRepository;
    }

    public int Insert(PaperAnswer paperAnswer)
    {
    return PaperAnswerRepository.Insert(paperAnswer);
    }

    public int DeleteById(long id)
    {
    return  PaperAnswerRepository.DeleteById(id);
    }

    public int Update(PaperAnswer paperAnswer)
    {
    return  PaperAnswerRepository.Update(paperAnswer);
    }

    }
    }

