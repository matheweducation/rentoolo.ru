﻿using Rentoolo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rentoolo.Account
{
    public partial class TenderRequests : System.Web.UI.Page
    {
        public List<TenderRequest> TRequests;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);

                TRequests = TendersHelper.GetTenderRequests(id);
            }

        }
    }
}