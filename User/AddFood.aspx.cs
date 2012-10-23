using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_AddFood : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

 
    protected void Button1_Click(object sender, EventArgs e)
    {
        Food objFood = new Food();

        objFood.Name = txtFoodName.Text;
        objFood.Description = txtDescription.Text;
        objFood.Price = Double.Parse(txtPrice.Text);
        objFood.RestaurantID = txtRestaurantID.Text;

        objFood.Remark = txtRemark.Text;

        DBFood objDBFood = new DBFood();

        if (objDBFood.insertFood(objFood))
        {
            if (!fluPicture.PostedFile.Equals(""))
                objDBFood.addPicture(objFood, fluPicture.FileBytes);
            
        }

    }
}
