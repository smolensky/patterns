namespace adapterPattern.adapterPattern
{
    public class DuckAdapter : ITurkey
    {
        private readonly IDuck _duck;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }

        public void Fly()
        {
            _duck.Fly();
        }

        public void Gobble()
        {
            _duck.Quack();
        }
    }
}