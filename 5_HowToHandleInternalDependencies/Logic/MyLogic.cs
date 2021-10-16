namespace Logic
{
    public class MyLogic
    {
        private readonly IDependencyWithSideeffect dependencyWithSideeffect;

        public MyLogic(IDependencyWithSideeffect dependencyWithSideeffect)
        {
            this.dependencyWithSideeffect = dependencyWithSideeffect;
        }

        public MyLogic(DependencyWithSideeffect dependencyWithSideeffect)
        {
            this.dependencyWithSideeffect = dependencyWithSideeffect;
        }

        public bool DoSomeImportantStuff()
        {
            dependencyWithSideeffect.DoingSomethingWithASideEffect();
            return true;
        }
    }
}