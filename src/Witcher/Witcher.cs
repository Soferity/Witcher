﻿#region Imports

using Witcher.Value;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Soferity.com
//     Created: 12.Apr.2021
//     Changed: 14.Apr.2021
//     Version: 1.0.0.2
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
                get => Values.Max;
                set => Values.Max = value;
            }

            /// <summary>
            /// 
            /// </summary>
            public static int DefaultTime
            {
                get => Values.Time;
            }

            /// <summary>
            /// 
            /// </summary>
            public static string StandardForm
            {
                get => Values.StandardForm;
                internal set => Values.StandardForm = value;
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