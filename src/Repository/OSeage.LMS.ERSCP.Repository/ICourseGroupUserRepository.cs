//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:57
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
using OSeage.LMS.ERSCP.Entity;

namespace OSeage.LMS.ERSCP.Repository
{
///<summary>
/// 课程小组用户表
///</summary>
public interface ICourseGroupUserRepository : IRepository<CourseGroupUser, long>
    ,IRepositoryAsync<CourseGroupUser, long>
        {

[Statement(Id = "GetEntity")]
        new CourseGroupUser GetById([Param("RowKey")]long id);
[Statement(Id = "GetEntity")]
        new Task<CourseGroupUser> GetByIdAsync([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new int DeleteById([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new Task<int> DeleteByIdAsync([Param("RowKey")]long id);
        }
        }

