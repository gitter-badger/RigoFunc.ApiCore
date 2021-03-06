﻿// Copyright (c) RigoFunc (xuyingting). All rights reserved.

namespace RigoFunc.ApiCore.Services {
    /// <summary>
    /// Represents all the options you can user to configure the service.
    /// </summary>
    public class SmsEmailOptions {
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>The name of the product.</value>
        public string ProductName { get; set; }
        /// <summary>
        /// Gets or sets the product value.
        /// </summary>
        /// <value>The product value.</value>
        public string ProductValue { get; set; }
        /// <summary>
        /// Gets or sets the Sms API URL.
        /// </summary>
        /// <value>The Sms API URL.</value>
        public string SmsApiUrl { get; set; }
        /// <summary>
        /// Gets or sets the email API URL.
        /// </summary>
        /// <value>The email API URL.</value>
        public string EmailApiUrl { get; set; }
    }
}
