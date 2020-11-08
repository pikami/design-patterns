namespace TE.Facade
{
    public class Facade
    {
        private protected Package1 package1;
        private protected Package2 package2;

        public Facade()
        {
            package1 = new Package1();
            package2 = new Package2();
        }

        public int GetValue()
        {
            var valueFromPackage1 = package1.GetValueFromPackage1();
            var valueFromPackage2 = package2.GetValueFromPackage2();

            return valueFromPackage1 + valueFromPackage2;
        }
    }
}
