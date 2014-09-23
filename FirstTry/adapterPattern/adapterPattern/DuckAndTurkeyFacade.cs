using System;

namespace adapterPattern.adapterPattern
{
    public class DuckAndTurkeyFacade
    {
        private readonly SimpleDuck _duck;
        private readonly SimpleTurkey _turkey;

        public DuckAndTurkeyFacade(SimpleDuck duck, SimpleTurkey turkey)
        {
            _duck = duck;
            _turkey = turkey;
        }

        public void IsWorking()
        {
            _duck.Quack();
            _duck.Fly();

            _turkey.Gobble();
            _turkey.Fly();
        }
    }
}