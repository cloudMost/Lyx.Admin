using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyx.Admin.Common.IO
{
    public static class FileHelper
    {
        /// <summary>
        /// 创建目录
        /// </summary>
        /// <param name="filePath">路径</param>
        public static void CreateDirectoryIfNot(string filePath)
        {
            string path = Path.Combine(filePath);
            
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
