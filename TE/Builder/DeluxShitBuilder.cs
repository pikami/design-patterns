using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Builder
{
    public class DeluxShitBuilder: IBuilder
    {
        Shit s = new Shit();
        public override void BuildPartA()
        {
            s.setConfiguration(s.getConfiguration() + "/DELUX sprickles1");
        }

        public override void BuildPartB()
        {
            s.setConfiguration(s.getConfiguration() + "/DELUX sprickles2");
        }

        public override Shit GetResult()
        {
            return s;
        }
    }
}
