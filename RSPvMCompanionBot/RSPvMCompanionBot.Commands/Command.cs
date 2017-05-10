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
        }

        protected abstract void AssignArgumentSpecifications();
        public abstract TReturn Execute();
    }
}
