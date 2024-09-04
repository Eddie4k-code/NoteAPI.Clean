/* Any concrete implementation of a UserRepository will implemenet this */

using NoteAPI.Domain;

public interface IUserRepository<T> where T: class {
    Task CreateUserAsync(T Entity);

    Task UpdateUserAsync(T Entity);

    Task DeleteUserAsync(T Entity);

    Task<List<T>> GetAllUsersAsync();

    Task<T> GetUserByIdAsync(int id);
}