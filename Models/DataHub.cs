using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tangenportalv2.Models
{
    public class DataHub : Hub
    {

        public async Task shakehands()
        {
            await Clients.All.SendAsync("validateconnection", "Message from the other side");
        }

    }
}
