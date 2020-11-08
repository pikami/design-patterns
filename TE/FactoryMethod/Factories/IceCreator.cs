using TE.FactoryMethod.Levels;

namespace TE.FactoryMethod.Factories
{
    public class IceCreator : LevelCreator
    {
        public override GameLevel CreateLevel()
        {
            return new IceLevel();
        }
    }
}
