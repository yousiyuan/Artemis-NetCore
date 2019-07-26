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
/// 试卷与知识点关系表
///</summary>
public interface IPaperRefKnowledgeRepository : IRepository<PaperRefKnowledge, long>
    ,IRepositoryAsync<PaperRefKnowledge, long>
        {

[Statement(Id = "GetEntity")]
        new PaperRefKnowledge GetById([Param("PaperKey")]long id);
[Statement(Id = "GetEntity")]
        new Task<PaperRefKnowledge> GetByIdAsync([Param("PaperKey")]long id);
[Statement(Id = "Delete")]
        new int DeleteById([Param("PaperKey")]long id);
[Statement(Id = "Delete")]
        new Task<int> DeleteByIdAsync([Param("PaperKey")]long id);
        }
        }

