using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR.SignalR
{
    [HubName("tableService")]
    public class MajorHub:Hub
    {
        public static void Show()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<MajorHub>();
            // 调用所有客户端的displayDatas方法
            context.Clients.All.displayDatas();
        }
    }
}