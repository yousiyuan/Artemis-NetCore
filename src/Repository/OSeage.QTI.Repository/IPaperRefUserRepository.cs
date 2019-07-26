//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:49
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
using OSeage.QTI.Entity;

namespace OSeage.QTI.Repository
{
///<summary>
/// 试卷与用户关系表
///</summary>
public interface IPaperRefUserRepository : IRepository<PaperRefUser, long>
    ,IRepositoryAsync<PaperRefUser, long>
        {

[Statement(Id = "GetEntity")]
        new PaperRefUser GetById([Param("RowKey")]long id);
[Statement(Id = "GetEntity")]
        new Task<PaperRefUser> GetByIdAsync([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new int DeleteById([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new Task<int> DeleteByIdAsync([Param("RowKey")]long id);
        }
        }

