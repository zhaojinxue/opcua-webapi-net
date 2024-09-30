/*
 * OPC UA Web API
 *
 * Provides simple HTTPS based access to an OPC UA server.
 *
 * The version of the OpenAPI document: 1.05.4
 * Contact: office@opcfoundation.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Opc.Ua.WebApi.Client.OpenAPIDateConverter;

namespace Opc.Ua.WebApi.Model
{
    /// <summary>
    /// Defines BrowseDirection
    /// </summary>
    public enum BrowseDirection
    {
        /// <summary>
        /// Enum Forward for value: 0
        /// </summary>
        Forward = 0,

        /// <summary>
        /// Enum Inverse for value: 1
        /// </summary>
        Inverse = 1,

        /// <summary>
        /// Enum Both for value: 2
        /// </summary>
        Both = 2,

        /// <summary>
        /// Enum Invalid for value: 3
        /// </summary>
        Invalid = 3
    }

}