using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
/// 

public class HUserType
{
     public const String TYPE_USER = "USER";
    public const String TYPE_ADMIN = "ADMIN";
}

public class HUserGender
{
     public const String MALE = "MALE";
     public const String FEMALE = "FEMALE";
}
public class HUser
{

    static public Boolean doLogin(String email, String password)
    {
        DBUser objdbuser = new DBUser();

        HUser loginUser = objdbuser.getUserByEmail(email, HUserType.TYPE_USER);

        if (loginUser == null)
            return false;

        if (!loginUser.Password.Equals(password))
            return false;
                
        return true ;
    } 

    static public  void doRegisterUser(System.Web.SessionState.HttpSessionState session, String email) {
        DBUser objdbuser = new DBUser();

        HUser loginUser = objdbuser.getUserByEmail(email, HUserType.TYPE_USER);

        if (loginUser == null)
            throw new Exception("user doesn't exists");

        session["userlogin"] = loginUser;
   }

    static public  HUser getLoginUser(System.Web.SessionState.HttpSessionState session)
    {
        HUser loginUser = (HUser)session["userlogin"];

        return loginUser;
   }

    
    private String pEmail;
    private String pName;
    private DateTime pDOB;
    private String pGender;
    private String pPassword;
    private String pType;

    public String Type
    {
        get
        {
            return pType;
        }

        set
        {
            pType = value;
        }
    }

    public String Password
    {
        get
        {
            return pPassword;
        }

        set
        {
            pPassword = value;
        }
    }

    public String Gender
    {
        get
        {
            return pGender;
        }

        set
        {
            pGender = value;
        }
    }

    public DateTime DOB
    {
        get {
            return pDOB;
        }

        set
        {
            pDOB = value;
        }

    }

    public String Name
    {
        get {
            return pName;
        }

        set {
            pName = value;
        }
    }

    public String Email
    {
        get
        {
            return pEmail;
        }
        set
        {
            pEmail = value;
        }
    }

        
	public HUser()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
