using Microsoft.AspNetCore.SignalR;

namespace Demo.Hubs
{
    public class ClarkHub : Hub
    {
        public ClarkHub()
        {
        }

        /// <summary>
        /// 連線
        /// </summary>
        public async override Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
        }

        /// <summary>
        /// 連線中斷 
        /// </summary>
        /// <param name="exception">例外物件</param>
        public async override Task OnDisconnectedAsync(Exception exception)
        {
            await base.OnDisconnectedAsync(exception);
        }

    }
}
