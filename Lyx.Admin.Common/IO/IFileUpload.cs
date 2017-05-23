using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lyx.Admin.Common
{
    /// <summary>
    /// 文件上传接口
    /// </summary>
    public interface IFileUpload
    {
        void Upload(HttpContextBase context, string subDir);
    }
}
