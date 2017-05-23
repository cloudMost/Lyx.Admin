using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.UI;

namespace Lyx.Admin.Common
{
    /// <summary>
    /// 数据校验
    /// </summary>
    public class DataChecker
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="express"></param>
        /// <param name="message"></param>
        public static void UserFriendlyExceptionIf(bool express,string message)
        {
            if (express==true)
            {
                throw new UserFriendlyException(message);
            }
        }
    }
}
