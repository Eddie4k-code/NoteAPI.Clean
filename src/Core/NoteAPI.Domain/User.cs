namespace NoteAPI.Domain{

public class User : BaseEntity {
    public string Username { get; set;}

    public string Password { get; set;}

    public ICollection<Note> Notes { get; set;}
}

}