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
/// 试卷与考试题关系表
///</summary>
    public class PaperRefQuestionService
    {
    public IPaperRefQuestionRepository PaperRefQuestionRepository { get; }

    public PaperRefQuestionService (IPaperRefQuestionRepository paperRefQuestionRepository)
    {
    PaperRefQuestionRepository = paperRefQuestionRepository;
    }

    public int Insert(PaperRefQuestion paperRefQuestion)
    {
    return PaperRefQuestionRepository.Insert(paperRefQuestion);
    }

    public int DeleteById(long id)
    {
    return  PaperRefQuestionRepository.DeleteById(id);
    }

    public int Update(PaperRefQuestion paperRefQuestion)
    {
    return  PaperRefQuestionRepository.Update(paperRefQuestion);
    }

    }
    }

