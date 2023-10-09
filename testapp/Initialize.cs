using testapp.DAL.Repositories;
using testapp.Enteties;

namespace testapp
{
    public static  class Initialize
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
           

            services.AddScoped<UserRepository>();

        }
    }
}
