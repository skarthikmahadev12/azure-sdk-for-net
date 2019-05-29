﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Azure.Messaging.EventHubs {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Azure.Messaging.EventHubs.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The received message (delivery-id:{0}, size:{1} bytes) exceeds the limit ({2} bytes) currently allowed on the link..
        /// </summary>
        internal static string AmqpMessageSizeExceeded {
            get {
                return ResourceManager.GetString("AmqpMessageSizeExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please make sure either all or none of the following arguments are defined: &apos;{0},{1}&apos;..
        /// </summary>
        internal static string ArgumentInvalidCombination {
            get {
                return ResourceManager.GetString("ArgumentInvalidCombination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; may not be null or empty..
        /// </summary>
        internal static string ArgumentNullOrEmpty {
            get {
                return ResourceManager.GetString("ArgumentNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; may not be null or white space..
        /// </summary>
        internal static string ArgumentNullOrWhiteSpace {
            get {
                return ResourceManager.GetString("ArgumentNullOrWhiteSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; cannot exceed {1} characters..
        /// </summary>
        internal static string ArgumentStringTooBig {
            get {
                return ResourceManager.GetString("ArgumentStringTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending empty {0} is not a valid operation..
        /// </summary>
        internal static string CannotSendAnEmptyEvent {
            get {
                return ResourceManager.GetString("CannotSendAnEmptyEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no event data supplied. Please make sure input events are not empty..
        /// </summary>
        internal static string EventDataListIsNullOrEmpty {
            get {
                return ResourceManager.GetString("EventDataListIsNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Serialization operation failed due to unsupported type {0}..
        /// </summary>
        internal static string FailedToSerializeUnsupportedType {
            get {
                return ResourceManager.GetString("FailedToSerializeUnsupportedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string has an invalid encoding format..
        /// </summary>
        internal static string InvalidEncoding {
            get {
                return ResourceManager.GetString("InvalidEncoding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The time period may not be Zero or Infinite..
        /// </summary>
        internal static string InvalidTimePeriod {
            get {
                return ResourceManager.GetString("InvalidTimePeriod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System property &apos;{0}&apos; is missing in the event..
        /// </summary>
        internal static string MissingSystemProperty {
            get {
                return ResourceManager.GetString("MissingSystemProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;identifier&apos; parameter exceeds the maximum allowed size of {0} characters..
        /// </summary>
        internal static string ReceiverIdentifierOverMaxValue {
            get {
                return ResourceManager.GetString("ReceiverIdentifierOverMaxValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be specified along with {1}. {0} alone should be sufficient to Authenticate the request..
        /// </summary>
        internal static string SasTokenShouldBeAlone {
            get {
                return ResourceManager.GetString("SasTokenShouldBeAlone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument {0} must be a positive timeout value. The provided value was {1}..
        /// </summary>
        internal static string TimeoutMustBePositive {
            get {
                return ResourceManager.GetString("TimeoutMustBePositive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument {0} must be a non-negative timespan value. The provided value was {1}..
        /// </summary>
        internal static string TimeSpanMustBeNonNegative {
            get {
                return ResourceManager.GetString("TimeSpanMustBeNonNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided token does not specify the &apos;Audience&apos; value..
        /// </summary>
        internal static string TokenMissingAudience {
            get {
                return ResourceManager.GetString("TokenMissingAudience", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided token does not specify the &apos;ExpiresOn&apos; value..
        /// </summary>
        internal static string TokenMissingExpiresOn {
            get {
                return ResourceManager.GetString("TokenMissingExpiresOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied must be between {0} and {1}..
        /// </summary>
        internal static string ValueOutOfRange {
            get {
                return ResourceManager.GetString("ValueOutOfRange", resourceCulture);
            }
        }
    }
}