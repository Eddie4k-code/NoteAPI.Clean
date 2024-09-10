using MediatR;
using NoteAPI.Application.Contracts;
using NoteAPI.Application.Errors;
using NoteAPI.Domain;

public class CreateUserHandler : IRequestHandler<CreateUserCommand<User>, int>
{

    private readonly IUserRepository<User> _userRepository;

    public CreateUserHandler(IUserRepository<User> userRepository) {

        this._userRepository = userRepository;

    }

    public async Task<int> Handle(CreateUserCommand<User> request, CancellationToken cancellationToken)
    {   

        var existingUser = await this._userRepository.GetUserByUsernameAsync(request.User.Username);

        if (existingUser == null) {
            throw new GenericBadRequest("User with that username already exists");
        }

        return await _userRepository.CreateUserAsync(request.User);
    }
}