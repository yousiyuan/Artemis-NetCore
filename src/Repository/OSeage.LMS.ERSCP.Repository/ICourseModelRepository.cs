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
/// 课程章节表
///</summary>
public interface ICourseModelRepository : IRepository<CourseModel, long>
    ,IRepositoryAsync<CourseModel, long>
        {

[Statement(Id = "GetEntity")]
        new CourseModel GetById([Param("RowKey")]long id);
[Statement(Id = "GetEntity")]
        new Task<CourseModel> GetByIdAsync([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new int DeleteById([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new Task<int> DeleteByIdAsync([Param("RowKey")]long id);
        }
        }

