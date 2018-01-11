
namespace IdentityServer4.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Options for cookie creation
    /// </summary>
    public class CookieOptions
    {
        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>
        /// The domain.
        /// </value>
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the name of the cookie.
        /// </summary>
        /// <value>
        /// The name of the cookie.
        /// </value>
        public string CookieName { get; set; }
    }
}
