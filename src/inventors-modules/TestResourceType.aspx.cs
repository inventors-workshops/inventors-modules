using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class TestResourceType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResourceTypeDataProvider resourceTypeDP = new ResourceTypeDataProvider();

            Listing.DataSource = resourceTypeDP.displayResourceTypes();

            Listing.DataBind();
        }

        protected void Listing_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ResourceTypeDataProvider resourceTypeDP = new ResourceTypeDataProvider();

            string resourceTypeKey = Listing.DataKeys[e.RowIndex].Values["PrKey"].ToString();

            int key = Int32.Parse(resourceTypeKey);

            bool click = resourceTypeDP.deleteResourceType(key);

            Listing.DataSource = resourceTypeDP.displayResourceTypes();
            Listing.DataBind();
        }

    }
}