using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CloudTutorial.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private AzureBlob MyBlob = new AzureBlob();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
           
        }

        public async void OnGet()
        {
            // ToDo: handle file list of all .jpg files
            // MyBlob.GetBlob("container", "cloudtutorial/cloudImages/DSCN1669.jpg");

            //await MyBlob.GetImageBlob( "cloudtutorial/cloudImages/DSCN1669.jpg");
        }

        public void saveEm()
        {
            // ToDo: handle file list of all .jpg files c:\cloudimages\
            //MyBlob.CreateAndSaveAzureBlob().Wait();  
        }
    }
}
