﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThanhHuongSolution.Common.LocResources {
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
    public class ProductManagementResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ProductManagementResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ThanhHuongSolution.Common.LocResources.ProductManagementResources", typeof(ProductManagementResources).Assembly);
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
        ///   Looks up a localized string similar to Mã sản phẩm không hợp lệ..
        /// </summary>
        public static string ID_INVALID {
            get {
                return ResourceManager.GetString("ID_INVALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hiện tại chưa có sản phẩm..
        /// </summary>
        public static string NO_PRODUCT {
            get {
                return ResourceManager.GetString("NO_PRODUCT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Số lượng sản phẩm nhỏ hơn 0..
        /// </summary>
        public static string NUMBER_LESS_THAN_ZERO {
            get {
                return ResourceManager.GetString("NUMBER_LESS_THAN_ZERO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã sản phẩm đã tồn tại..
        /// </summary>
        public static string PRODUCT_EXIST {
            get {
                return ResourceManager.GetString("PRODUCT_EXIST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã sản phẩm không được rỗng..
        /// </summary>
        public static string PRODUCT_ID_EMPTY {
            get {
                return ResourceManager.GetString("PRODUCT_ID_EMPTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sản phẩm này vẫn còn tồn kho, không thể xoá..
        /// </summary>
        public static string PRODUCT_NUMBER_GREATER_THAN_ZERO {
            get {
                return ResourceManager.GetString("PRODUCT_NUMBER_GREATER_THAN_ZERO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã sản phẩm không được rỗng..
        /// </summary>
        public static string TRACKING_NUMBER_EMPTY {
            get {
                return ResourceManager.GetString("TRACKING_NUMBER_EMPTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã sản phẩm đã tồn tại..
        /// </summary>
        public static string TRACKING_NUMBER_EXIST {
            get {
                return ResourceManager.GetString("TRACKING_NUMBER_EXIST", resourceCulture);
            }
        }
    }
}
