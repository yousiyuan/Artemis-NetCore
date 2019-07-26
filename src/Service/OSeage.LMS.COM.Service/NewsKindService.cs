//*******************************
// Create By 流年 公子
// Date 2019-07-03 14:02
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Linq;
using OSeage.LMS.COM.Entity;
using OSeage.LMS.COM.Repository;

namespace OSeage.LMS.COM.Service
{
    ///<summary>
/// 新闻分类
///</summary>
    public class NewsKindService
    {
    public INewsKindRepository NewsKindRepository { get; }

    public NewsKindService (INewsKindRepository newsKindRepository)
    {
    NewsKindRepository = newsKindRepository;
    }

    public int Insert(NewsKind newsKind)
    {
    return NewsKindRepository.Insert(newsKind);
    }

    public int DeleteById(long id)
    {
    return  NewsKindRepository.DeleteById(id);
    }

    public int Update(NewsKind newsKind)
    {
    return  NewsKindRepository.Update(newsKind);
    }

    }
    }

