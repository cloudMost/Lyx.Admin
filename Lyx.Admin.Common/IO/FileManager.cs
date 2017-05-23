using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using Abp.Dependency;
using Lyx.Admin;

namespace Lyx.Admin.Common.IO
{
    /// <summary>
    /// 文件管理
    /// </summary>
    public class FileManager:IFileUpload, ITransientDependency
    {

        private readonly IAppPathSetting _AppPath;

        public FileManager(IAppPathSetting AppPath)
        {
            _AppPath = AppPath;
        }

        public void Upload(HttpContextBase context,string subDir)
        {
            var httpContext = context.Request;

            string path = Path.Combine(_AppPath.FileUploadPath,subDir);

            FileHelper.CreateDirectoryIfNot(path);
            foreach (string file in httpContext.Files)
            {

            }
        }

    }

}
