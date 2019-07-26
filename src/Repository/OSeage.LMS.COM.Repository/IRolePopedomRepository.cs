//*******************************
// Create By 流年 公子
// Date 2019-07-03 14:02
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SmartSql.DyRepository;
using SmartSql.DyRepository.Annotations;
using OSeage.LMS.COM.Entity;

namespace OSeage.LMS.COM.Repository
{
///<summary>
/// 角色权限表
///</summary>
public interface IRolePopedomRepository : IRepository<RolePopedom, long>
    ,IRepositoryAsync<RolePopedom, long>
        {

[Statement(Id = "GetEntity")]
        new RolePopedom GetById([Param("RowKey")]long id);
[Statement(Id = "GetEntity")]
        new Task<RolePopedom> GetByIdAsync([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new int DeleteById([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new Task<int> DeleteByIdAsync([Param("RowKey")]long id);
        }
        }

