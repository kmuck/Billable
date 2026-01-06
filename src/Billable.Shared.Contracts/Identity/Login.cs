namespace Billable.Shared.Contracts.Identity;

public record LoginRequest(
    string Email,
    string Password
);

public record LoginResponse(
    string b
);