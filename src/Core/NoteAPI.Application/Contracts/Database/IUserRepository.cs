/* Any concrete implementation of a UserRepository will implemenet this */

namespace NoteAPI.Application.Contracts;

using NoteAPI.Domain;

public interface IUserRepository<T> where T: class {
    Task<int> CreateUserAsync(T Entity);

    Task UpdateUserAsync(T Entity);

    Task DeleteUserAsync(T Entity);

    Task<List<T>> GetAllUsersAsync();

    Task<T> GetUserByIdAsync(int id);

    Task<T> GetUserByUsernameAsync(string username);
}