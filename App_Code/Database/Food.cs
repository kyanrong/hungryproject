using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Food
/// </summary>
public class Food

{
    private String pName;
    private String pRestaurantID;
    private Double pPrice;
    private String pDescription;
    private String pRemark;

    public String Remark
    {
        get
        {
            return pRemark;

        }

        set
        {
            pRemark = value;
        }
    }

    public String Description
    {
        get
        {
            return pDescription;
        }

        set
        {
            pDescription = value;
        }
    }

    public String Name
    {
        get
        {
            return pName;
        }

        set
        {
            pName = value;
        }
    }

    public String RestaurantID
    {
        get
        {
            return pRestaurantID;
        }
        set
        {
            pRestaurantID = value;
        }
    }

    public Double Price
    {
        get
        {
            return pPrice;
        }

        set
        {
            pPrice = value;
        }
    }
	public Food()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
