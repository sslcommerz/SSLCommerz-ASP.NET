
## Process flow to integrate SSLCommerz by using ASP.Net sample code.

1. First create your Sanbox(Test Environment) store account from below url. After registration you will get two mail. One for Store_id and Store_password. Another one for Report panel access.	
	   https://developer.sslcommerz.com/registration/
	   Note: For live store id or account you have to communicate with us. Our mail address: operation@sslcommerz.com
2. Then give the store_id and store_password in Default.aspx.cs and Success.aspx.cs page. 

3. To send a Payment request using this ASP.Net code snippet, User need to construct a NameValueCollection, as shown in Page_Load method of Default.aspx.cs.

4. After constructing this NameValueCollection, SSLCommerz Class is instantiated with user store Id and password. Then InitiateTransaction Method is called which will return a URL or JSON list depending on user choice of receiving Gateway list or not.
5. User will hit that URL returned by previous InitiateTransaction method call. That will prompt user to choose payment option and perform payment procedures. After completing payment, SSL Commerz page will redirect user to “success_url” defined by user during initial parameter NameValueCollection construction in previous Call to initiateTransaction method.
6. User should pass MerchantTrxID, MerchantTrxAmount, MerchantTrxCurrency, HttpRequest into this method: Page_Load of Success.aspx.cs 
This will validate those query parameters returned by payment success redirect, and return true if successful transaction and false otherwise.

In case of false, user should check status in that first returned response.


## Help URL
 1. https://developer.sslcommerz.com/docs.html :URL to start integrate SSLCOMMERZ as a Developer 
 2. https://developer.sslcommerz.com/registration/: URL to Create Account in Sandbox

## Check List After Making the site Live or Connect with Live SSLCOMMERZ
Customer need to do a live transaction to check the full process. After the transaction below things need to ensure

1. Transaction is showing successful in SSLCOMMERZ Panel (https://report.sslcommerz.com)
2. Transaction details are same in SSLCOMMERZ Panel (https://report.sslcommerz.com) and Customer site admin Panel.
3. Transaction amount is same in Issuer bank end.
4. In Transaction Details API Validated by Merchant is YES.

Note: In the gateway you may not found Banks. After getting live store id, it takes 10 to 15 working days to enable these. You may follow up your KAM(Key Account Manager).