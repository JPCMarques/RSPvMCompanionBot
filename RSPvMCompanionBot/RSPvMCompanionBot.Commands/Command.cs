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
        protected ArgumentData ArgumentData;

        public Command(string root, ArgumentData argumentData)
        {
            Root = root;
            ArgumentData = argumentData;
        }

        public abstract TReturn Execute();
    }
}
