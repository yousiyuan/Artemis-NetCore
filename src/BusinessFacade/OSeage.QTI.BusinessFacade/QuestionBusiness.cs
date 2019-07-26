using System;
using System.Collections.Generic;
using System.Text;
using OSeage.QTI.BusinessFacade.Core;
using OSeage.QTI.Entity;
using OSeage.QTI.Repository;
using OSeage.QTI.Service;

namespace OSeage.QTI.BusinessFacade
{
    public class QuestionBusiness
    {
        public IQuestionRepository QuestionRepositoryScope { get; internal set; }

        public CategoryService CategoryServiceScope { get; internal set; }

        [QtiService]
        public QuestionBusiness(IQuestionRepository questionRepositoryScope = null, CategoryService categoryServiceScope = null)
        {
            QuestionRepositoryScope = questionRepositoryScope;
            CategoryServiceScope = categoryServiceScope;
        }

        public Question GetQuestionByRowKey(long rowkey)
        {
            var question = QuestionRepositoryScope.GetById(rowkey);
            return question;
        }

        public Category GetCategoryByRowKey(long rowkey)
        {
            var category = CategoryServiceScope.CategoryRepository.GetById(rowkey);
            return category;
        }
    }
}
