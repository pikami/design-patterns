using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Builder
{
    public class ShitBuilder:IBuilder
    {
        Shit s = new Shit();
        public override void BuildPartA()
        {
            s.setConfiguration(s.getConfiguration() + "/sprickles1");
        }

        public override void BuildPartB()
        {
            s.setConfiguration(s.getConfiguration() + "/sprickles2");
        }

        public override Shit GetResult()
        {
            return s;
        }
    }
}
