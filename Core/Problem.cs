namespace Core
{
    public abstract class Problem
    {
        protected Problem() { }

        public abstract string Name { get; }
        public abstract void Execute();
    }
}