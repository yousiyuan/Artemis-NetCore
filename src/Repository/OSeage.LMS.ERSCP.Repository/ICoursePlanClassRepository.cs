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
/// 开课计划班级表
///</summary>
public interface ICoursePlanClassRepository : IRepository<CoursePlanClass, long>
    ,IRepositoryAsync<CoursePlanClass, long>
        {

[Statement(Id = "GetEntity")]
        new CoursePlanClass GetById([Param("RowKey")]long id);
[Statement(Id = "GetEntity")]
        new Task<CoursePlanClass> GetByIdAsync([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new int DeleteById([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new Task<int> DeleteByIdAsync([Param("RowKey")]long id);
        }
        }

