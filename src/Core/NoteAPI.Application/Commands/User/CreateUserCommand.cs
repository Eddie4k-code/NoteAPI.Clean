using MediatR;
using NoteAPI.Domain;

public class CreateUserCommand<T> : IRequest<int> {
    public T User {get; set;}
}

