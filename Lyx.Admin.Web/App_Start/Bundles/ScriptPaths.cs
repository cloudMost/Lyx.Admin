using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lyx.Admin.Web
{
    /// <summary>
    /// js路径统一管理
    /// </summary>
    public static class ScriptPaths
    {
        public const string Main = "~/js/main.js";

        #region Jquery
        public const string JQuery = "~/Scripts/jquery/jquery-2.2.0.min.js";
        public const string JQuery_Migrate = "~/Scripts/jquery/jquery-migrate.min.js";
        public const string JQuery_UI = "~/Scripts/jquery-ui/jquery-ui.min.js";
        public const string JQuery_Slimscroll = "~/Scripts/jquery-slimscroll/jquery.slimscroll.min.js";
        public const string JQuery_BlockUi = "~/Scripts/jquery-blockui/jquery.blockui.min.js";
        public const string JQuery_Cookie = "~/Scripts/jquery-cookie/jquery.cookie.min.js";
        public const string JQuery_Uniform = "~/Scripts/jquery-uniform/jquery.uniform.min.js";
        public const string JQuery_Ajax_Form = "~/Scripts/jquery-ajax-form/jquery.form.js";
        public const string JQuery_Sparkline = "~/Scripts/jquery-sparkline/jquery.sparkline.min.js";
        public const string JQuery_Validation = "~/Scripts/jquery-validation/js/jquery.validate.min.js";
        public const string JQuery_jTable = "~/Scripts/jquery-jtable/jquery.jtable.min.js";
        public const string JQuery_Bootstrap_Switch = "~/Scripts/bootstrap-switch/js/bootstrap-switch.min.js";
        public const string JQuery_Color = "~/Scripts/jcrop/js/jquery.color.js";
        public const string JQuery_Jcrop = "~/Scripts/jcrop/js/jquery.Jcrop.min.js";
        #endregion

        #region Bootstrap
        public const string Bootstrap = "~/Scripts/bootstrap/js/bootstrap.min.js";
        public const string Bootstrap_Hover_Dropdown = "~/Scripts/bootstrap-hover-dropdown/bootstrap-hover-dropdown.min.js";
        public const string Bootstrap_DateRangePicker = "~/Scripts/bootstrap-daterangepicker/daterangepicker.js";
        public const string Bootstrap_Select = "~/Scripts/bootstrap-select/bootstrap-select.min.js";
        public const string Bootstrap_Switch = "~/Scripts/bootstrap-switch/js/bootstrap-switch.min.js"; 
        #endregion


        public const string SweetAlert = "~/Scripts/sweetalert/sweet-alert.min.js";
        public const string Toastr = "~/Scripts/toastr/toastr.min.js";
        public const string Moment = "~/Scripts/moment.min.js";
        public const string Ckeditor = "~/Scripts/ckeditor/ckeditor.js";


        public const string Metronic = "~/Metronic/assets/global/scripts/metronic.js";
        public const string Metronic_Layout = "~/Metronic/assets/admin/layout4/scripts/layout.js";
        public const string Metronic_Quick_Sidebar = "~/Metronic/assets/admin/layout4/scripts/quick-sidebar.js";
        public const string Metronic_Demo = "~/Metronic/assets/admin/layout4/scripts/demo.js";

        #region ABP框架部分
        public const string Abp = "~/Abp/Framework/scripts/abp.js";
        public const string Abp_JQuery = "~/Abp/Framework/scripts/libs/abp.jquery.js";
        public const string Abp_Toastr = "~/Abp/Framework/scripts/libs/abp.toastr.js";
        public const string Abp_BlockUi = "~/Abp/Framework/scripts/libs/abp.blockUI.js";
        public const string Abp_SpinJs = "~/Abp/Framework/scripts/libs/abp.spin.js";
        public const string Abp_SweetAlert = "~/Abp/Framework/scripts/libs/abp.sweet-alert.js";
        public const string Abp_jTable = "~/Abp/Framework/scripts/libs/abp.jtable.js";
        public const string Abp_Ng = "~/Abp/Framework/scripts/libs/angularjs/abp.ng.js";
        #endregion

    }
}