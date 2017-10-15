namespace HHE.Wpf3dFoo.ViewModel
{
    internal sealed class MainViewModel
    {                     
        public WorldViewModel World { get; }

        public MainViewModel()
        {
            World = new WorldViewModel();
        }
    }
}
