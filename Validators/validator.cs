using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;

namespace Microsoft.BotBuilderSamples.Validators
{
    public static class Validator
    {
        public static Task<bool> ValidateAsync(PromptValidatorContext<string> promptValidator, CancellationToken cancellationToken)
        {
            var temp = "hogehoge";

            return Task.FromResult(false);
        }
    }
}