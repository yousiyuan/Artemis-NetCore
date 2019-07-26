//*******************************
// Create By 流年 公子
// Date 2019-07-03 14:02
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************

using System;
namespace OSeage.LMS.COM.Entity
{

    ///<summary>
/// 系统配置
///</summary>
    public class SysConfig
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// logo, nvarchar
///</summary>
public string Logo { get; set; }
///<summary>
/// 系统名称
///</summary>
public string SysName { get; set; }
///<summary>
/// 底部
///</summary>
public string Footer { get; set; }
///<summary>
/// 说明
///</summary>
public string Description { get; set; }
///<summary>
/// 关键字
///</summary>
public string Keyword { get; set; }
///<summary>
/// 语言
///</summary>
public string Language { get; set; }
///<summary>
/// 邮件服务器地址
///</summary>
public string MailServer { get; set; }
///<summary>
/// 发送者姓名
///</summary>
public string MailServerName { get; set; }
///<summary>
/// 邮箱密码
///</summary>
public string MailPwd { get; set; }
///<summary>
/// smtp
///</summary>
public string MailSmtp { get; set; }
///<summary>
/// ssl
///</summary>
public bool? MailWithSsl { get; set; }
///<summary>
/// 端口
///</summary>
public string MailPort { get; set; }
///<summary>
/// 证书
///</summary>
public string MailCert { get; set; }
///<summary>
/// 首页banner
///</summary>
public string Banner { get; set; }
///<summary>
/// 密码复杂度
///</summary>
public string SecurityPolicy { get; set; }
///<summary>
/// 课程列表横幅
///</summary>
public string CourseListPage { get; set; }
///<summary>
/// 课程详情横幅
///</summary>
public string CourseDetailPage { get; set; }
///<summary>
/// 考试横幅
///</summary>
public string ExamPage { get; set; }
///<summary>
/// 新闻列表横幅
///</summary>
public string NewsListPage { get; set; }
///<summary>
/// 新闻详情横幅
///</summary>
public string NewsDetailPage { get; set; }
///<summary>
/// 创建者
///</summary>
public long? Creator { get; set; }
///<summary>
/// 创建时间
///</summary>
public DateTime? CreateTime { get; set; }
///<summary>
/// 修改者
///</summary>
public long? Editor { get; set; }
///<summary>
/// 修改时间
///</summary>
public DateTime? UpdateTime { get; set; }
///<summary>
/// 逻辑状态：1正常；0逻辑删除
///</summary>
public bool? Status { get; set; }
    }
    }

