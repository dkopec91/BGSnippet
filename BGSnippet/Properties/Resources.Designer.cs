﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BGSnippet.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BGSnippet.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to BGSnippet will no longer be started at Windows startup from the following path:
        ///
        ///{0}.
        /// </summary>
        internal static string AutostartOffMessage {
            get {
                return ResourceManager.GetString("AutostartOffMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Autostart disabled.
        /// </summary>
        internal static string AutostartOffTitle {
            get {
                return ResourceManager.GetString("AutostartOffTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BGSnippet will be started at Windows startup from the following path:
        ///
        ///{0}.
        /// </summary>
        internal static string AutostartOnMessage {
            get {
                return ResourceManager.GetString("AutostartOnMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Autostart enabled.
        /// </summary>
        internal static string AutostartOnTitle {
            get {
                return ResourceManager.GetString("AutostartOnTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exit.
        /// </summary>
        internal static string Exit {
            get {
                return ResourceManager.GetString("Exit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pause.
        /// </summary>
        internal static string Pause {
            get {
                return ResourceManager.GetString("Pause", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resume.
        /// </summary>
        internal static string Resume {
            get {
                return ResourceManager.GetString("Resume", resourceCulture);
            }
        }
    }
}
