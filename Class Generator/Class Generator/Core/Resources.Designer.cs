﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Core.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;AccessModifier&gt; class &lt;Classname&gt;
        ///{
        ///	&lt;FieldTemplate&gt;
        ///}.
        /// </summary>
        internal static string ClassTemplate {
            get {
                return ResourceManager.GetString("ClassTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public &lt;FieldName&gt; &lt;DataType&gt; {set; get;}.
        /// </summary>
        internal static string FieldTemplate {
            get {
                return ResourceManager.GetString("FieldTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT 
        ///		T.name [Name],
        ///		schema_name(T.schema_id) [SchemaName],
        ///		c.name [Name],
        ///		TY.name [DataType],
        ///		C.max_length [Size] ,
        ///		C.is_nullable [AllowNull]
        ///	FROM SYS.tables T
        ///	INNER JOIN SYS.all_columns C
        ///	ON T.object_id = C.object_id
        ///	INNER JOIN SYS.types TY
        ///	ON C.system_type_id = TY.system_type_id
        ///	WHERE T.name &lt;&gt; &apos;sysdiagrams&apos;
        ///	ORDER BY T.name.
        /// </summary>
        internal static string SQLServerQuery {
            get {
                return ResourceManager.GetString("SQLServerQuery", resourceCulture);
            }
        }
    }
}