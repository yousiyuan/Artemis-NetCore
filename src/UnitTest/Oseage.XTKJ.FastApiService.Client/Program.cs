using BeetleX.FastHttpApi;
using BeetleX.FastHttpApi.Clients;
using BeetleX.FastHttpApi.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Oseage.XTKJ.FastApiService.Client
{
    class Program
    {
        static HttpClusterApi HttpClusterApi;

        static IDemoController DemoService { get; set; }
        static IAccountController AccountController { get; set; }
        static IPublicController PublicController { get; set; }

        static void Main(string[] args)
        {
            #region 创建访问服务的接口对象

            //TODO:
            //  集群配置【待完善】
            //HttpClusterApi = new HttpClusterApi();
            //HttpClusterApi.AddHost("*", "http://localhost:9090");

            //DemoService = HttpClusterApi.Create<IDemoController>();
            //AccountController = HttpClusterApi.Create<IAccountController>();
            //PublicController = HttpClusterApi.Create<IPublicController>();

            //非集群调用
            //实际运用时，DemoService、AccountController、PublicController 对象由容器中获得
            HttpApiClient client = new HttpApiClient("http://localhost:9090");
            DemoService = client.Create<IDemoController>();
            AccountController = client.Create<IAccountController>();
            PublicController = client.Create<IPublicController>();

            #endregion

            #region 测试服务的调用

            object result = null;

            Console.WriteLine("=======================GetQuestionList=======================");
            result = DemoService.GetQuestionList("test token info").Result;
            Console.WriteLine(result);

            Console.WriteLine("=======================Login=======================");
            result = AccountController.Login(new { userName = "zxb", password = "123456", verifyCode = "sdh35" }).Result;
            Console.WriteLine(result);

            Console.WriteLine("=======================SayHello=======================");
            result = PublicController.SayHello("她是莉娜").Result;
            Console.WriteLine(result);

            Console.WriteLine("=======================GetJsonData=======================");
            result = PublicController.GetJsonData("犹似缘", "男", "你看你看月亮的脸").Result;
            Console.WriteLine(result);

            Console.WriteLine("=======================Post=======================");
            result = PublicController.Post(new { name = "諸葛冷冷", value = "30嵗" }).Result;
            Console.WriteLine(result);

            Console.WriteLine("=======================PostFormReturnJson=======================");
            result = PublicController.PostFormReturnJson("test111", "test222").Result;
            Console.WriteLine(result);

            Console.WriteLine("=======================PostForm=======================");
            result = PublicController.PostForm("觅尽尘缘", "哦耶").Result;
            Console.WriteLine(result);

            Console.WriteLine("=======================UploadFile=======================");
            //TODO:
            // 通過接口形式的文件上傳方式，在服務端暫時無法獲取文件流，等待詢問作者之後，給出正確方式
            var fileUrl = "C:\\testfileupload.txt";
            FileStream fs = new FileStream(fileUrl, FileMode.Open, FileAccess.Read);
            var data = new MultipartFormDataContent();
            data.Add(new StreamContent(fs));
            result = PublicController.UploadFile("这是一个配置文件", data).Result;
            Console.WriteLine(result);

            Console.WriteLine("=======================PostStream=======================");
            result = PublicController.PostStream("读取数据流：有些场需要读取数据流来转换自定义的数据，这种方式组件可以这样按以下方式来做").Result;
            result = HttpUtility.UrlDecode(result.ToString());
            Console.WriteLine(result);

            #endregion

            #region 测试文件的上传
            Console.WriteLine("=======================组装HTTP报文实现文件上传=======================");
            UploadParameterType parameters = new UploadParameterType();
            parameters.Url = "http://localhost:9090/api/public/uploadfile";
            parameters.FileNameValue = "testfileupload.txt";
            parameters.UploadStream = fs;
            parameters.PostParameters.Add("remark", "这是一个配置文件");
            var uploadResult = HttpUploadClient.Execute(parameters);
            Console.WriteLine(uploadResult);
            #endregion

            Console.ReadKey();
        }
    }

    [Controller(BaseUrl = "com/demo")]
    public interface IDemoController
    {
        [Post]
        Task<object> GetQuestionList([CHeader(Name = "authorization")] string authorization);
    }

    [Controller(BaseUrl = "api/account")]
    public interface IAccountController
    {
        [Post]
        [JsonFormater]
        Task<object> Login(object body);
    }

    [Controller(BaseUrl = "api/public")]
    public interface IPublicController
    {
        [Get]
        [CQuery(Name = "name", Value = "我是公子")]
        Task<object> SayHello([CQuery(Name = "value")]string value);

        [Get]
        Task<object> GetJsonData(string name, string value, string gaga);

        [Post]
        [JsonFormater]
        Task<object> Post(object body);

        [Post]
        Task<object> PostFormReturnJson(string name, string value);

        [Post]
        Task<object> PostForm(string name, string value);

        [Post]
        [MultiDataConvert]
        Task<object> UploadFile([CQuery]string remark, MultipartFormDataContent httpContent);

        [Post]
        Task<object> PostStream(object body);
    }
}