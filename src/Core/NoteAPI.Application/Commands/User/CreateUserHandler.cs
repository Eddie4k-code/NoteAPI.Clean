using MediatR;
using NoteAPI.Application.Contracts;
using NoteAPI.Domain;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
{

    private readonly IUserRepository<User> _userRepository;

    public CreateUserHandler(IUserRepository<User> userRepository) {

        this._userRepository = userRepository;

    }

    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        return await _userRepository.CreateUserAsync(request.User);
    }
}