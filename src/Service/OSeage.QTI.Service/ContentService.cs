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
/// 考试题内容表
///</summary>
    public class ContentService
    {
    public IContentRepository ContentRepository { get; }

    public ContentService (IContentRepository contentRepository)
    {
    ContentRepository = contentRepository;
    }

    public int Insert(Content content)
    {
    return ContentRepository.Insert(content);
    }

    public int DeleteById(long id)
    {
    return  ContentRepository.DeleteById(id);
    }

    public int Update(Content content)
    {
    return  ContentRepository.Update(content);
    }

    }
    }

