using Abp.Dependency;
using System.IO;
using System.Web;

namespace Lyx.Admin.Common.IO
{
    /// <summary>
    /// 文件管理
    /// </summary>
    public class FileManager:IFileUpload, ITransientDependency
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileUploadPath">文件上传路径</param>
        public FileManager()
        {

        }
        public void Upload(HttpContextBase context,string fileUploadPath)
        {
            var httpContext = context.Request;
            //创建目录
            FileHelper.CreateDirectoryIfNot(fileUploadPath);
            foreach (string file in httpContext.Files)
            {
                var f = httpContext.Files[file];
                string fileName = Path.Combine(fileUploadPath, f.FileName);
                f.SaveAs(fileName);
            }

        }

    }

}
