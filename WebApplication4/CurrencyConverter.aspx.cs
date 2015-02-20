using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CurrencyConverter : System.Web.UI.Page
{
    protected void Convert_ServerClick(object sender, EventArgs e)
    {
        decimal USAmount = Decimal.Parse(US.Value);
        decimal euroAmount = USAmount * (Decimal)0.85;
        Result.InnerText = USAmount.ToString() + "U.S. dollars=";
        Result.InnerText += euroAmount.ToString() + "Euros.";
    }
}