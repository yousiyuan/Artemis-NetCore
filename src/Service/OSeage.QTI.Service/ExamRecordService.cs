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
/// 答卷记录表
///</summary>
    public class ExamRecordService
    {
    public IExamRecordRepository ExamRecordRepository { get; }

    public ExamRecordService (IExamRecordRepository examRecordRepository)
    {
    ExamRecordRepository = examRecordRepository;
    }

    public int Insert(ExamRecord examRecord)
    {
    return ExamRecordRepository.Insert(examRecord);
    }

    public int DeleteById(long id)
    {
    return  ExamRecordRepository.DeleteById(id);
    }

    public int Update(ExamRecord examRecord)
    {
    return  ExamRecordRepository.Update(examRecord);
    }

    }
    }

