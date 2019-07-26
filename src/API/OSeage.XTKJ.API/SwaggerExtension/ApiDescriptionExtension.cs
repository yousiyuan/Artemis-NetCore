using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OSeage.XTKJ.API.SwaggerExtension
{
    /// <summary>
    /// API描述器扩展
    /// </summary>
    public static class ApiDescriptionExtension
    {
        /// <summary>
        /// 获取区域名称
        /// </summary>
        public static List<string> GetAreaNameList(this ApiDescription description)
        {
            //string controlName = description.ActionDescriptor.RouteValues["controller"];
            var areaName = description.GetAreaName();
            return new List<string> { areaName };
        }

        /// <summary>
        /// 获取区域名称(小写)
        /// </summary>
        public static string GetAreaName(this ApiDescription description)
        {
            return description.RelativePath.Split('/').FirstOrDefault();
            //return Regex.Match(description.ActionDescriptor.DisplayName, @"Area.([^,]+)\.C").Groups[1].ToString().Replace(".", "");
        }
    }
}
