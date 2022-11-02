using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string baseUrl = Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + "/";

        // CREATING LIST OF POST DATA
        NameValueCollection PostData = new NameValueCollection();
        PostData.Add("total_amount", "100.00");
        PostData.Add("tran_id", "test_tran_1");
        PostData.Add("success_url",baseUrl+"Success.aspx");
        PostData.Add("fail_url", baseUrl+"Fail.aspx"); // "Fail.aspx" page needs to be created
        PostData.Add("cancel_url", baseUrl+"Cancel.aspx"); // "Cancel.aspx" page needs to be created
        // PostData.Add("ipn_url", baseUrl+"IPN.aspx"); // If IPN is implemented, provide the url;

        PostData.Add("cus_name", "ABC XY");
        PostData.Add("cus_email", "abc.xyz@example.com");
        PostData.Add("cus_add1", "Address Line One");
        PostData.Add("cus_add2", "Address Line Two");
        PostData.Add("cus_city", "Dhaka");
        PostData.Add("cus_postcode", "1000");
        PostData.Add("cus_country", "Bangladesh");
        PostData.Add("cus_phone", "0171111111");

  		PostData.Add("shipping_method", "NO");
		PostData.Add("num_of_item", "1");
		PostData.Add("product_name", "Demo");
		PostData.Add("product_profile", "general");
		PostData.Add("product_category", "Demo");

        // Add more parameters as needed. Parameter reference page - https://developer.sslcommerz.com/doc/v4/#initiate-payment

        SSLCommerz sslcz = new SSLCommerz("<your store id>", "<your store password>", true); // Use true for sandbox, false for live.
        String response = sslcz.InitiateTransaction(PostData);
        Response.Redirect(response);
    }
}
