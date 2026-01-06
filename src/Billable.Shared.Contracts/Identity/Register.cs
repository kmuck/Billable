namespace Billable.Shared.Contracts.Identity;

public record RegisterRequest(
    string Email,
    string Password
);

public record RegisterResponse(
    string b
);