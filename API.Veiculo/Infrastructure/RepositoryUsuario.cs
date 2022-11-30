using Domain.Interfaces;
using Entities.Entities;
using Infrastructure.Repositories.Generics;

namespace Infrastructure
{
    public class RepositoryUsuario : RepositoryGenerics<Usuario>, IUsuario
    {
    }
}
