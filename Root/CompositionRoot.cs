using Microsoft.Extensions.DependencyInjection;

namespace Root
{
    public class CompositionRoot
    {
        protected CompositionRoot() { }
        public static void InjectDependencies(IServiceCollection services, string connectionString)
        {
            
            #region database injection
            #endregion

            #region repositories injection
            #endregion

            #region services injection
            #endregion

            #region others injection
            #endregion

        }

    }
}
