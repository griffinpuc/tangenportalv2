using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tangenportalv2.Models
{
    public class DataHub : Hub
    {
        public async Task updateStatus(string status, int instrument_ID, string colorcode)
        {
            await Clients.All.SendAsync("push", status, instrument_ID, colorcode);
        }

        public async Task streamLine(string line)
        {
            await Clients.All.SendAsync("stream", line);
        }

    }
}
