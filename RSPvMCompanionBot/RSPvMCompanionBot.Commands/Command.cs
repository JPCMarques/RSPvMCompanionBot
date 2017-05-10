using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Commands
{
    public abstract class Command<TReturn>
    {
        protected string Root;
        protected string[] Args;
        protected string[] OptArgs;
        protected int MinArgs, MaxArgs;

        public Command(string root, int minArgs = 0, int maxArgs = 0, string[] args = null, string[] optArgs = null)
        {
            Root = root;
            MinArgs = minArgs;
            MaxArgs = maxArgs;
            Args = args;
            OptArgs = optArgs;
        }

        public abstract TReturn Execute();
    }
}
