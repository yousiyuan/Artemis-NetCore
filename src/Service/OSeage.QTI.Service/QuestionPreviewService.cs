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
    public class QuestionPreviewService
    {
    public IQuestionPreviewRepository QuestionPreviewRepository { get; }

    public QuestionPreviewService (IQuestionPreviewRepository questionPreviewRepository)
    {
    QuestionPreviewRepository = questionPreviewRepository;
    }

    public int Insert(QuestionPreview questionPreview)
    {
    return QuestionPreviewRepository.Insert(questionPreview);
    }

    public int DeleteById(long id)
    {
    return  QuestionPreviewRepository.DeleteById(id);
    }

    public int Update(QuestionPreview questionPreview)
    {
    return  QuestionPreviewRepository.Update(questionPreview);
    }

    }
    }

