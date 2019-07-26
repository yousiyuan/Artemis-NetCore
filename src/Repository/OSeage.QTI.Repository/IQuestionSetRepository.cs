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
/// 试题预览记录表
///</summary>
public interface IQuestionSetRepository : IRepository<QuestionSet, long>
    ,IRepositoryAsync<QuestionSet, long>
        {

[Statement(Id = "GetEntity")]
        new QuestionSet GetById([Param("UserKey")]long id);
[Statement(Id = "GetEntity")]
        new Task<QuestionSet> GetByIdAsync([Param("UserKey")]long id);
[Statement(Id = "Delete")]
        new int DeleteById([Param("UserKey")]long id);
[Statement(Id = "Delete")]
        new Task<int> DeleteByIdAsync([Param("UserKey")]long id);
        }
        }

