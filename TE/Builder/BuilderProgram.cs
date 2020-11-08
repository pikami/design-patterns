using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Builder
{
    class BuilderProgram
    {
        public static void BuilderMain()
        {
            Director director = new Director();
            IBuilder b1 = new ShitBuilder();
            IBuilder b2 = new DeluxShitBuilder();


            System.Console.WriteLine("Builder-----------------------");
            // Construct two products

            director.Construct(b1);

            Shit p1 = b1.GetResult();

            System.Console.WriteLine(p1.getConfiguration());



            director.Construct(b2);

            Shit p2 = b2.GetResult();

            System.Console.WriteLine(p2.getConfiguration());
        }
    }
}
