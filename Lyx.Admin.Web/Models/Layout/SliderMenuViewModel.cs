using Abp.Application.Navigation;

namespace Lyx.Admin.Web.Models.Layout
{
    public class SliderMenuViewModel
    {
        public UserMenu MainMenu { get; set; }

        public string ActiveMenuItemName { get; set; }
    }
}