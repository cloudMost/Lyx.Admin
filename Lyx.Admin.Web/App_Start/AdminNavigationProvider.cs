using Abp.Application.Navigation;
using Abp.Localization;
using Lyx.Admin.Authorization;

namespace Lyx.Admin.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See Views/Layout/_TopMenu.cshtml file to know how to render menu.
    /// </summary>
    public class AdminNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "System",
                        L("SystemPage"),
                        url: "System",
                        icon: "fa fa-home"
                    ).AddItem(
                        new MenuItemDefinition(
                            "FileManage",
                            L("FileManagePage"),
                            url: "/FileManage",
                            icon: "fa fa-home"
                        )
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        "Spider",
                        L("SpiderPage"),
                        url: "Spider",
                        icon:"fa fa-home"
                    ).AddItem(
                        new MenuItemDefinition(
                            "SettingSpider",
                            L("SettingSpiderPage"),
                            url: "/SettingSpider",
                            icon: "fa fa-home"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "NovelSpider",
                            L("NovelSpiderPage"),
                            url: "/NovelSpider",
                            icon:"fa fa-home"
                        )
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        "TaoJin",
                        L("TaoJinPage"),
                        url:"TaoJin",
                        icon:"fa fa-home"
                    ).AddItem(
                        new MenuItemDefinition(
                            "TaoJinEarn",
                            L("TaoJinEarnPage"),
                            url: "TaoJinEarn",
                            icon: "fa fa-home"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "TaoJinEarnSta",
                            L("TaoJinEarnStaPage"),
                            url: "TaoJinEarnSta",
                            icon: "fa fa-home"
                        )
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AdminConsts.LocalizationSourceName);
        }
    }
}
