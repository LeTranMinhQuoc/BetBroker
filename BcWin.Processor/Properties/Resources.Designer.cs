﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BcWin.Processor.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BcWin.Processor.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///     &lt;head&gt;
        ///          &lt;title&gt;&lt;/title&gt;
        ///		  &lt;script&gt;
        ///		  var IeVer = (function () {
        ///    var c,
        ///    d = 3,
        ///    b = document.createElement(&apos;div&apos;),
        ///    a = b.getElementsByTagName(&apos;i&apos;);
        ///    while (b.innerHTML = &apos;&lt;!--[if gt IE &apos; + (++d) + &apos;]&gt;&lt;i&gt;&lt;/i&gt;&lt;![endif]--&gt;&apos;, a[0]) {
        ///    }
        ///    return d &gt; 4 ? d : c
        ///}());
        ///function fxn(a, b) {
        ///    if (a.keyCode == 13) {
        ///        if (b == &apos;D&apos;) {
        ///            return callSubmit(&apos;&apos;, &apos;D&apos;)
        ///        } else {
        ///            if (!checkValidationCode()) {
        ///               [rest of string was truncated]&quot;;.
        /// </summary>
        public static string LoginIbet {
            get {
                return ResourceManager.GetString("LoginIbet", resourceCulture);
            }
        }
    }
}