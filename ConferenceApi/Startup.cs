using Conference.Core.Domain.ConferenceRooms.Common;
using Conference.Infrastructure.Core.Domain.ConferenceRooms.Commom;
using Conference.Infrastructure.Core.Domain.ConferenceRooms.Common;
namespace ConferenceApi
{
    

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IConferenceRoomRepository, ConferenceRoomRepository>();
            services.AddSingleton<IConferenceRoomService, ConferenceRoomService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
