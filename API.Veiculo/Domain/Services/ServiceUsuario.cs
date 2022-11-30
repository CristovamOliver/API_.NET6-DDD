using Domain.Interfaces;
using Domain.Interfaces.InterfaceServices;

namespace Domain.Services { 
    public class ServiceUsuario : IServiceUsuario
    {
        private readonly IUsuario _usuario;

        public ServiceUsuario(IUsuario usuario)
        {
            _usuario = usuario; 
        }
            
    }
}
