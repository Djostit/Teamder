namespace TeamderStaff
{
    internal class ViewModelLocator
    {
        private static ServiceProvider _provider;
        public static void Init()
        {
            var services = new ServiceCollection();

            #region ViewModels
            
            services.AddTransient<mWindowViewModel>();
            
            #endregion
            
            #region Services

            #endregion

            _provider = services.BuildServiceProvider();

            foreach (var service in services)
            {
                _provider.GetRequiredService(service.ServiceType);
            }
        }
        public mWindowViewModel mWindowViewModel => _provider.GetRequiredService<mWindowViewModel>();
    }
}
