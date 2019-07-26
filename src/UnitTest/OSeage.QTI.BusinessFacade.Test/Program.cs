using System;

namespace OSeage.QTI.BusinessFacade.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionBusiness questionBusiness = new QuestionBusiness();
            var category = questionBusiness.GetCategoryByRowKey(12L);
            var question = questionBusiness.GetQuestionByRowKey(636969476362871460L);

            Console.WriteLine(category);
            Console.WriteLine(question);

            Console.WriteLine("Hello World!");
        }
    }
}
