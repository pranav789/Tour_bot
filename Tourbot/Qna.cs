using Microsoft.Bot.Builder.Dialogs;
using QnAMakerDialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Tourbot
{
    [Serializable]
    [QnAMakerService(" 0365752a293a43b38a0e1510f79b38c3", "1477d0c9-0196-4ce4-b3c4-3b85c8e4c95f")]
    public class Qna : QnAMakerDialog<object>
    {
        public override async Task NoMatchHandler(IDialogContext context,string originalQueryText)
        {
            await context.PostAsync($"Sorry");
            context.Wait(MessageReceived);
        }
        
        public void StartAsync(IDialogContext context)
        {
            context.Wait(this.MessageReceivedAsync);
        }

        private Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            throw new NotImplementedException();
        }
    }
}