namespace NoteAPI.Application.Errors;

public class GenericBadRequest : Exception {
    
    public string message;

    public GenericBadRequest(string message) : base(message) 
    {
        this.message = message;
    }

    
}