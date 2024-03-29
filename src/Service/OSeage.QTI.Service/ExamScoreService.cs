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
/// 考试成绩表
///</summary>
    public class ExamScoreService
    {
    public IExamScoreRepository ExamScoreRepository { get; }

    public ExamScoreService (IExamScoreRepository examScoreRepository)
    {
    ExamScoreRepository = examScoreRepository;
    }

    public int Insert(ExamScore examScore)
    {
    return ExamScoreRepository.Insert(examScore);
    }

    public int DeleteById(long id)
    {
    return  ExamScoreRepository.DeleteById(id);
    }

    public int Update(ExamScore examScore)
    {
    return  ExamScoreRepository.Update(examScore);
    }

    }
    }

