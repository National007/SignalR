using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalR.App_Start.Startup))]

namespace SignalR.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //路由映射Signalr
           app.MapSignalR();

        }
    }
}
