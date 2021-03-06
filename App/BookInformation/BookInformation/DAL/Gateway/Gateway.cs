﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace BookInformation.DAL.Gateway
{
    public class Gateway
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }
        public string Query { get; set; }

        public string connectionstring = WebConfigurationManager.ConnectionStrings["BookDBConnection"].ConnectionString;

        public Gateway()
        {
            Connection=new SqlConnection(connectionstring);
        }
    }
}