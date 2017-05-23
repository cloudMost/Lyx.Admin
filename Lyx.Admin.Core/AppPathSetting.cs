using Abp.Dependency;

namespace Lyx.Admin
{
    public class AppPathSetting : IAppPathSetting,ISingletonDependency
    {
        public string FileTempPath
        {
            get;set;
        }

        public string FileUploadPath
        {
            get;set;
        }
    }
}
