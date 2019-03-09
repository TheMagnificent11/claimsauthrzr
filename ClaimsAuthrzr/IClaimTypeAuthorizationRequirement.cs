using Microsoft.AspNetCore.Authorization;

namespace ClaimsAuthrzr
{
    /// <summary>
    /// Claim Type Authorization Requirement Interface
    /// </summary>
    public interface IClaimTypeAuthorizationRequirement : IAuthorizationRequirement
    {
        /// <summary>
        /// Gets the claim type
        /// </summary>
        string ClaimType { get; }
    }
}
