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
/// 登录记录表
///</summary>
    public class LoginLogService
    {
    public ILoginLogRepository LoginLogRepository { get; }

    public LoginLogService (ILoginLogRepository loginLogRepository)
    {
    LoginLogRepository = loginLogRepository;
    }

    public int Insert(LoginLog loginLog)
    {
    return LoginLogRepository.Insert(loginLog);
    }

    public int DeleteById(long id)
    {
    return  LoginLogRepository.DeleteById(id);
    }

    public int Update(LoginLog loginLog)
    {
    return  LoginLogRepository.Update(loginLog);
    }

    }
    }

