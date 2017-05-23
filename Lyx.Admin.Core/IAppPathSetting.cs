namespace Lyx.Admin
{
    public interface IAppPathSetting
    {
        /// <summary>
        /// 文件临时目录
        /// </summary>
        string FileTempPath { get; }
        /// <summary>
        /// 文件上传目录
        /// </summary>
        string FileUploadPath { get; }
    }
}
