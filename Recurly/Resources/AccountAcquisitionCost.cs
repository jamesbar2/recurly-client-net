/**
 * This file is automatically created by Recurly's OpenAPI generation process
 * and thus any edits you make by hand will be lost. If you wish to make a
 * change to this file, please create a Github issue explaining the changes you
 * need and we will usher them to the appropriate places.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Recurly.Resources {
  [ExcludeFromCodeCoverage] 
  public class AccountAcquisitionCost : Request {
  
    /// <value>The amount of the corresponding currency used to acquire the account.</value>
    [JsonProperty("amount")]
    public float? Amount { get; set; }
  
    /// <value>3-letter ISO 4217 currency code.</value>
    [JsonProperty("currency")]
    public string Currency { get; set; }
  
  }
}
