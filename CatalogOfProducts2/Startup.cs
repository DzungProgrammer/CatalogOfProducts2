﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CatalogOfProducts2.Startup))]
namespace CatalogOfProducts2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}