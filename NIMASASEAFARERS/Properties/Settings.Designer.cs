﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NIMASASEAFARERS.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=nimasamlsserver.database.windows.net;Initial Catalog=NIMASAMLS.MDF;Us" +
            "er ID=nimasamls;Password=********;Connect Timeout=30;Encrypt=True;TrustServerCer" +
            "tificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")]
        public string NIMASAMLSConnectionString {
            get {
                return ((string)(this["NIMASAMLSConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=nmlsdocks.database.windows.net,1433;Initial Catalog=NIMASAMLSBAK;User" +
            " ID=nmls;Password=Seafarer2;Connect Timeout=30;Encrypt=True;TrustServerCertifica" +
            "te=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")]
        public string NIMASAMLSBAKConnectionString {
            get {
                return ((string)(this["NIMASAMLSBAKConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=nmlsdocks.database.windows.net;Initial Catalog=NIMASAMLSBAK;User ID=n" +
            "mls;Password=Seafarer2")]
        public string NIMASAMLSBAKConnectionString1 {
            get {
                return ((string)(this["NIMASAMLSBAKConnectionString1"]));
            }
        }
    }
}