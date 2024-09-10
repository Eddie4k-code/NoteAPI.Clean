using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace NoteAPI.Application
{

    /* 
    
    Extend the IServiceCollection to create a method that allows us to add application services 
    returns services we want to add
    */
public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.

        return services;
    }
}

}