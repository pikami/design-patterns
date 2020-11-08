using TE.FactoryMethod.Levels;

namespace TE.FactoryMethod.Factories
{
    public class OasisCreator : LevelCreator
    {
        public override GameLevel CreateLevel()
        {
            return new OasisLevel();
        }
    }
}
