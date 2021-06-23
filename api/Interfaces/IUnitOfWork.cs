using System.Threading.Tasks;

namespace api.Interfaces
{
    public interface IUnitOfWork
    {
         IUserRepository UserRepository { get; }
         IMessageRepository MessageRepository { get; }
         ILikesRepository LikesRepository { get; }
         IPhotoRepository PhotoRepository { get; }
         Task<bool> Complete();
         bool HasChanges();
    }
}