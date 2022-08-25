﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace ChannelNotification.Model
{
    public class Encryptedcontent
    {
        /// <summary>
        /// Encrypted data.
        /// </summary>
        public string data { get; set; }

        /// <summary>
        /// Encrypted data signature.
        /// </summary>
        public string dataSignature { get; set; }
        public string dataKey { get; set; }

        /// <summary>
        /// Certificate key.
        /// </summary>
        public string encryptionCertificateId { get; set; }

        /// <summary>
        ///.Certificate thumbprint.
        /// </summary>
        public string encryptionCertificateThumbprint { get; set; }
    }
}
