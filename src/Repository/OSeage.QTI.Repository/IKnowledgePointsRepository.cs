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
/// 知识点
///</summary>
public interface IKnowledgePointsRepository : IRepository<KnowledgePoints, long>
    ,IRepositoryAsync<KnowledgePoints, long>
        {

[Statement(Id = "GetEntity")]
        new KnowledgePoints GetById([Param("RowKey")]long id);
[Statement(Id = "GetEntity")]
        new Task<KnowledgePoints> GetByIdAsync([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new int DeleteById([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new Task<int> DeleteByIdAsync([Param("RowKey")]long id);
        }
        }

