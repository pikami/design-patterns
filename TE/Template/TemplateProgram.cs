namespace TE.Template
{
    class TemplateProgram
    {
        public static void TemplateMain()
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
        }
    }
}
