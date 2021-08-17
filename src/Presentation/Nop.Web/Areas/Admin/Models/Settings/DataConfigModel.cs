using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Settings
{
    public partial record DataConfigModel : BaseNopModel, IConfigModel
    {
        #region Properties

        [NopResourceDisplayName("Admin.Configuration.AppSettings.Data.ConnectionString")]
        public string ConnectionString { get; set; }

        [NopResourceDisplayName("Admin.Configuration.AppSettings.Data.DataProvider")]
        public string DataProvider { get; set; }

        [NopResourceDisplayName("Admin.Configuration.AppSettings.Data.SQLCommandTimeout")]
        public string SQLCommandTimeout { get; set; }

    #endregion
}
}
