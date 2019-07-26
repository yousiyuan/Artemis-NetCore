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
/// 用户表
///</summary>
    public class UserService
    {
    public IUserRepository UserRepository { get; }

    public UserService (IUserRepository userRepository)
    {
    UserRepository = userRepository;
    }

    public int Insert(User user)
    {
    return UserRepository.Insert(user);
    }

    public int DeleteById(long id)
    {
    return  UserRepository.DeleteById(id);
    }

    public int Update(User user)
    {
    return  UserRepository.Update(user);
    }

    }
    }

