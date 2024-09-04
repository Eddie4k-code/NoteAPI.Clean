/* Any concrete implementation of a UserRepository will implemenet this */

using NoteAPI.Domain;

public interface INoteRepository<T> where T: class {
    Task CreateNoteAsync(T Entity);

    Task UpdateNoteAsync(T Entity);

    Task DeleteNoteAsync(T Entity);

    Task<List<T>> GetAllNotesAsync();

    Task<T> GetUserByIdAsync(int id);
}