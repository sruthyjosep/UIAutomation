﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewToursFlights {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
    internal sealed partial class NewToursFlightsSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static NewToursFlightsSettings defaultInstance = ((NewToursFlightsSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new NewToursFlightsSettings())));
        
        public static NewToursFlightsSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Chrome")]
        public string Browser {
            get {
                return ((string)(this["Browser"]));
            }
            set {
                this["Browser"] = value;
            }
        }
    }
}
