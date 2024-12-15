//using Microsoft.AspNetCore.SignalR;

//namespace InhumanShopApp.Hubs
//{
//    public class ChatHub : Hub
//    {
//        public async Task SendMessage(string veterinaryId, string message)
//        {
//            // Изпращане на съобщение до избрания ветеринар
//            await Clients.User(veterinaryId).SendAsync("ReceiveMessage", Context.UserIdentifier, message);
//        }
//    }
//}
