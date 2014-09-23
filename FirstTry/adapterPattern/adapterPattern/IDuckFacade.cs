namespace adapterPattern.adapterPattern
{
    public interface IDuckFacade
    {
        void DoThings();
    }

    public class DuckAndTurkeyFacade : IDuckFacade
    {
        public void DoThings()
        {
            var simpleDuck = new SimpleDuck();
            var simpleTurkey = new SimpleTurkey();

            simpleTurkey.Gobble();
            simpleTurkey.Fly();

            simpleDuck.Quack();
            simpleDuck.Fly();
        }
    }
}