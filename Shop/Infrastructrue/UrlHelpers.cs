using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Infrastructrue
{
    public static class UrlHelpers 
    {
        public static string CategoryIconsPath(this IUrlHelper helper, string categoryIconName)
        {
            var CategoryIconsFolder = AppConfig.CategoryIconsRelativePath;
            var path = Path.Combine(CategoryIconsFolder, categoryIconName);
            var relativePath = helper.Content(path);
        
            return relativePath;
        }

        public static string ProductImagesPath(this IUrlHelper helper, string productImageName)
        {
            var ProductImagesFolder = AppConfig.ProductImagesRelativePath;
            var path = Path.Combine(ProductImagesFolder, "no_data.png");
            
            if (productImageName != null)
            {
                path = Path.Combine(ProductImagesFolder, productImageName);
            }
        
            var relativePath = helper.Content(path);


            return relativePath;
        }
    }
}
