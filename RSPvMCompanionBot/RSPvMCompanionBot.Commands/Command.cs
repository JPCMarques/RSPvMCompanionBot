using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Commands
{
    public abstract class Command<TReturn>
    {
        public string Root;
        public ArgumentSpecification ArgSpec;
        public ArgumentData ArgData;

        public Command(string root, ArgumentSpecification argSpec)
        {
            Root = root;
            ArgSpec = argSpec;
            AssignArgumentSpecifications();
        }

        protected abstract void AssignArgumentSpecifications();
        protected abstract bool IsValidCommandCall();
        protected abstract TReturn CommandLogic();

        public TReturn Execute(string input)
        {
            if (IsValidCommandCall())
            {
                return CommandLogic();
            }
            else
            {
                throw new ArgumentException("The command call is not valid. Check if you passed all the arguments correctly.");
            }
        }
    }
}
