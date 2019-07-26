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
/// 新闻
///</summary>
    public class NewsInfoService
    {
    public INewsInfoRepository NewsInfoRepository { get; }

    public NewsInfoService (INewsInfoRepository newsInfoRepository)
    {
    NewsInfoRepository = newsInfoRepository;
    }

    public int Insert(NewsInfo newsInfo)
    {
    return NewsInfoRepository.Insert(newsInfo);
    }

    public int DeleteById(long id)
    {
    return  NewsInfoRepository.DeleteById(id);
    }

    public int Update(NewsInfo newsInfo)
    {
    return  NewsInfoRepository.Update(newsInfo);
    }

    }
    }

