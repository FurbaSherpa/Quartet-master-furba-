﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class Signup : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            
        }
        signUpBtn.Click += new EventHandler(this.SignUpBtn_Click);
    }

    protected void SignUpBtn_Click(object sender, EventArgs e)
    {
        
    }


}

  
