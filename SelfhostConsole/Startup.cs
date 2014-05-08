﻿using System.Linq;
using System.Web.Http;
using Owin;

namespace SelfhostConsole
{
	public class Startup
	{
		public void Configuration(IAppBuilder appBuilder)
		{
			var config = new HttpConfiguration();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new {id = RouteParameter.Optional}
				);

			config.Routes.MapHttpRoute(
				name: "Html",
				//routeTemplate: "{controller}/{view}",
				routeTemplate: "{*view}",
				defaults: new {view = "index.html", controller = "home"}
				);

			appBuilder.UseWebApi(config);
		}
	}
}