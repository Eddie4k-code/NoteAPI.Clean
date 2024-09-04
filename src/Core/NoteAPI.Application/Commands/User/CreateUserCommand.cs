using MediatR;
using NoteAPI.Domain;

public class CreateUserCommand : IRequest<int> {
    public User User {get; set;}
}

