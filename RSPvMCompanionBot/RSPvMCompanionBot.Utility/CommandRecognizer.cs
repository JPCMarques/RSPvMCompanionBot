using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Utility
{
    public abstract class CommandRecognizer
    {
        protected string CommandRoot;
        protected ICollection<Regex> OptArgsRecognizers;

        public CommandRecognizer (string commandRoot) {
            CommandRoot = commandRoot;
            Init();
        }

        protected abstract void Init();

        public virtual void AddOptArgsRecognizer(Regex recognizer)
        {
            OptArgsRecognizers.Add(recognizer);
        }


    }
}
