//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:57
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************

using System;
namespace OSeage.LMS.ERSCP.Entity
{

    ///<summary>
/// 知识点
///</summary>
    public class KnowledgePoints
    {
///<summary>
/// 标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 知识点标题
///</summary>
public string Title { get; set; }
///<summary>
/// 知识点描述
///</summary>
public string Description { get; set; }
///<summary>
/// 排序
///</summary>
public int Sort { get; set; }
///<summary>
/// 状态:1-有效2-无效3-删除
///</summary>
public string Status { get; set; }
///<summary>
/// 所属单位标识
///</summary>
public long? BelongToKey { get; set; }
///<summary>
/// 所属单位名称
///</summary>
public string BelongToName { get; set; }
///<summary>
/// 所属学科标识
///</summary>
public long? SubjectKey { get; set; }
///<summary>
/// 所属学科名称
///</summary>
public string SubjectName { get; set; }
///<summary>
/// 所属课程标识
///</summary>
public long? CourseKey { get; set; }
///<summary>
/// 所属课程名称
///</summary>
public string CourseName { get; set; }
///<summary>
/// 所属章节标识
///</summary>
public long? ChapterKey { get; set; }
///<summary>
/// 所属章节名称
///</summary>
public string ChapterName { get; set; }
///<summary>
/// 所属小节标识
///</summary>
public long? SectionKey { get; set; }
///<summary>
/// 所属小节名称
///</summary>
public string SectionName { get; set; }
///<summary>
/// 所属模块标识(模块与章同级，其下没有小节)
///</summary>
public long? ModuleKey { get; set; }
///<summary>
/// 所属模块名称(模块与章同级，其下没有小节)
///</summary>
public string ModuleName { get; set; }
///<summary>
/// 上级知识点标识
///</summary>
public long? ParentKey { get; set; }
///<summary>
/// 创建者标识
///</summary>
public long? CreateCode { get; set; }
///<summary>
/// 创建者账号
///</summary>
public string CreateName { get; set; }
///<summary>
/// 创建时间
///</summary>
public DateTime CreateTime { get; set; }
///<summary>
/// 修改者标识
///</summary>
public long? UpdateCode { get; set; }
///<summary>
/// 修改者账号
///</summary>
public string UpdateName { get; set; }
///<summary>
/// 修改时间
///</summary>
public DateTime UpdateTime { get; set; }
///<summary>
/// 备注
///</summary>
public string Remark { get; set; }
    }
    }

