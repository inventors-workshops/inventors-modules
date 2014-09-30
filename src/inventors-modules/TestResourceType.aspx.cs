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
        ResourceTypeDataProvider resourceTypeDP = new ResourceTypeDataProvider();

        protected void Page_Load(object sender, EventArgs e)
        {

            IEnumerable<ResourceType> resourceType = resourceTypeDP.DisplayAllResourceTypes();

            Listing.DataSource = resourceType;

            Listing.DataBind();
        }

        protected void Listing_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            IEnumerable<ResourceType> resourceType = resourceTypeDP.DisplayAllResourceTypes();

            string resourceTypeKey = Listing.DataKeys[e.RowIndex].Values["PrKey"].ToString();

            int key = Int32.Parse(resourceTypeKey);

            bool click = resourceTypeDP.deleteResourceType(key);

            Listing.DataSource = resourceType;
            Listing.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            IEnumerable<ResourceType> resourceType = resourceTypeDP.DisplayAllResourceTypes();
            resourceTypeDP.Create(resourceTypeName.Text.Trim(), checking.Checked);

            Listing.DataSource = resourceType;
            Listing.DataBind();
        }

    }
}