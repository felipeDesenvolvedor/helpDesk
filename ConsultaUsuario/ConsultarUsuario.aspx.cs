﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using controller;

public partial class ConsultarUsuario : System.Web.UI.Page
{
    ControllerUsuario controll = new ControllerUsuario();
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = controll.consultarUsuarioController();
        GridView1.DataBind();

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}