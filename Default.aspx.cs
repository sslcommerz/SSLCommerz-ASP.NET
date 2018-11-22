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
        PostData.Add("total_amount", "1150.00");
        PostData.Add("tran_id", "TESTASPNET1234");
        PostData.Add("success_url",baseUrl+"Success.aspx");
        PostData.Add("fail_url", "https://sandbox.sslcommerz.com/developer/fail.php");
        PostData.Add("cancel_url", "https://sandbox.sslcommerz.com/developer/cancel.php");
        PostData.Add("version", "3.00");
        PostData.Add("cus_name", "ABC XY");
        PostData.Add("cus_email", "abc.xyz@mail.co");
        PostData.Add( "cus_add1", "Address Line On");
        PostData.Add("cus_add2", "Address Line Tw");
        PostData.Add("cus_city", "City Nam");
        PostData.Add("cus_state", "State Nam");
        PostData.Add("cus_postcode", "Post Cod");
        PostData.Add("cus_country", "Countr");
        PostData.Add("cus_phone", "0111111111");
        PostData.Add("cus_fax", "0171111111");
        PostData.Add("ship_name", "ABC XY");
        PostData.Add("ship_add1", "Address Line On");
        PostData.Add("ship_add2", "Address Line Tw");
        PostData.Add("ship_city", "City Nam");
        PostData.Add("ship_state", "State Nam");
        PostData.Add("ship_postcode", "Post Cod");
        PostData.Add("ship_country", "Countr");
        PostData.Add("value_a", "ref00");
        PostData.Add("value_b", "ref00");
        PostData.Add("value_c", "ref00");
        PostData.Add("value_d", "ref00");

        SSLCommerz sslcz = new SSLCommerz("YOUR STORE ID", "YOUR STORE PASSWORD");
        String response = sslcz.InitiateTransaction(PostData);
        Response.Redirect(response);
    }
}
