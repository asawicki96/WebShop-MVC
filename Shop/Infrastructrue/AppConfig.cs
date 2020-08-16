using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Infrastructrue
{
    public class AppConfig
    {
        // Should use ConfigurationManager.AppSettings[key] but for some reason it still returns null 
        public static string CategoryIconsRelativePath { get; } = "~/Content/Categories/";

        public static string ProductImagesRelativePath { get; } = "~/Content/Products/";
    }
}
