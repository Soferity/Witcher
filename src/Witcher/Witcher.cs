﻿#region Imports

using Witcher.Value;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Soferity.com
//     Created: 12.Apr.2021
//     Changed: 22.Dec.2021
//     Version: 1.0.0.3
//
// |---------DO-NOT-REMOVE---------|

namespace Witcher
{
    #region Core

    /// <summary>
    /// 
    /// </summary>
    public class Witcher
    {
        #region Property

        /// <summary>
        /// 
        /// </summary>
        public class Property
        {
            /// <summary>
            /// 
            /// </summary>
            public static int MaxOpen
            {
                get => Values.MaxOpen;
                set => Values.MaxOpen = value;
            }

            /// <summary>
            /// 
            /// </summary>
            public static int DefaultTime
            {
                get => Values.DefaultTime;
                internal set => Values.DefaultTime = value;
            }

            /// <summary>
            /// 
            /// </summary>
            public static string ManagementName
            {
                get => Values.ManagementName;
                internal set => Values.ManagementName = value;
            }

            /// <summary>
            /// 
            /// </summary>
            public static string NotifyName
            {
                get => Values.NotifyName;
                internal set => Values.NotifyName = value;
            }
        }

        #endregion

        #region Witch

        /// <summary>
        /// 
        /// </summary>
        internal class Witch
        {
            //
        }

        #endregion
    }

    #endregion
}