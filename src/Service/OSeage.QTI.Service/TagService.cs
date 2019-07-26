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
/// 标签表
///</summary>
    public class TagService
    {
    public ITagRepository TagRepository { get; }

    public TagService (ITagRepository tagRepository)
    {
    TagRepository = tagRepository;
    }

    public int Insert(Tag tag)
    {
    return TagRepository.Insert(tag);
    }

    public int DeleteById(long id)
    {
    return  TagRepository.DeleteById(id);
    }

    public int Update(Tag tag)
    {
    return  TagRepository.Update(tag);
    }

    }
    }

