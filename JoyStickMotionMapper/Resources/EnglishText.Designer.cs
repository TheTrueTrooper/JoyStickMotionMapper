﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JoyStickMotionMapper.Resources {
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
    internal class EnglishText {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal EnglishText() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JoyStickMotionMapper.Resources.EnglishText", typeof(EnglishText).Assembly);
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
        ///   Looks up a localized string similar to A usable last use config could not be found. Reverting to default values. Please fill in as required and a last config will be made on exit for next time..
        /// </summary>
        internal static string Exception_CantFindLastConfigException {
            get {
                return ResourceManager.GetString("Exception_CantFindLastConfigException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A usable config could not be found. Reverting to default values. Please fill in as required and a last config will be made on exit for next time..
        /// </summary>
        internal static string Exception_CantFindUsableConfigException {
            get {
                return ResourceManager.GetString("Exception_CantFindUsableConfigException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to That path doesnt exist..
        /// </summary>
        internal static string Exception_FileDoesentExistException {
            get {
                return ResourceManager.GetString("Exception_FileDoesentExistException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opps, Something went wrong!.
        /// </summary>
        internal static string Exception_GenaricOppsException {
            get {
                return ResourceManager.GetString("Exception_GenaricOppsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to About
        ///This is a place to place any of the required information for your motions communication protocol.
        ///
        ///Note
        ///Every protocol is different so please defer to the protocols section here for any required help.
        ///
        ///Supported Protocols
        ///  1.Com Port (RS-232)
        ///      About
        ///        RS-232 is the protocol layed out on com ports. It is a smiple bi-directional with one line in and out one line in protocol for communication. It is based on based on electrical signal timings or buads.
        ///      Help
        ///        Simply ins [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Help_ProtocolConnectionStringHelp {
            get {
                return ResourceManager.GetString("Help_ProtocolConnectionStringHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to About
        ///This is for games that start and change the process under which they run.
        ///
        ///How To
        ///Simply find the process name that is resulting from the start of the game in the task manager after starting it with out this system.
        ///
        ///Note
        ///If the process is left blank it will assume that the process is the directly started process from the exe..
        /// </summary>
        internal static string Help_RuntimeProcessNameHelp {
            get {
                return ResourceManager.GetString("Help_RuntimeProcessNameHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to About
        ///This is adding input after the game starts for any required start input.
        ///
        ///How To
        ///Simply add the below commands as nessary with spaces in the middle.
        ///
        ///Supported Commands
        ///wait(miliseconds) &lt;&lt; Waits a desired number of miliseconds before the next command 
        ///leftmouseclickdown(x,y) &lt;&lt; Sends a left mouse click (down) message to the other window as input at the x and y
        ///leftmouseclickup(x,y) &lt;&lt; Sends a left mouse click (up) message to the other window as input at the x and y
        ///keydown(sting) &lt;&lt; Sends a [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Help_StartOptionsInputHelp {
            get {
                return ResourceManager.GetString("Help_StartOptionsInputHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to About
        ///This is a place to place any of the required (command line or shortcut or otherwhise) start options you may need.
        ///
        ///Note
        ///Every process is different so please defer to the process&apos;s documention for any required help..
        /// </summary>
        internal static string Help_StartOptionsRunArgsHelp {
            get {
                return ResourceManager.GetString("Help_StartOptionsRunArgsHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Oops, unable to find process. Please run the process independently and find the desired process in the Task Manager. Time out was .
        /// </summary>
        internal static string HelpMessage_GameLaunchCatchErrorHelpMessage {
            get {
                return ResourceManager.GetString("HelpMessage_GameLaunchCatchErrorHelpMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Oops, game failed to launch.\nPlease contact your IT with this exception for help..
        /// </summary>
        internal static string HelpMessage_GameLaunchErrorHelpMessage {
            get {
                return ResourceManager.GetString("HelpMessage_GameLaunchErrorHelpMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Game file could not be found. Please check the game path before retrying..
        /// </summary>
        internal static string HelpMessage_GameNotFoundHelpMessage {
            get {
                return ResourceManager.GetString("HelpMessage_GameNotFoundHelpMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Joystcik wasn&apos;t selected. Please check your joystick selection before retrying..
        /// </summary>
        internal static string HelpMessage_RunJoyStickNotSelectedMessage {
            get {
                return ResourceManager.GetString("HelpMessage_RunJoyStickNotSelectedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to locate the folder for the output to be saved to. Please check your output path before retrying..
        /// </summary>
        internal static string HelpMessage_RunOutputErrorPathMessage {
            get {
                return ResourceManager.GetString("HelpMessage_RunOutputErrorPathMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protocol wasn&apos;t selected. Please check your protocol selection before retrying..
        /// </summary>
        internal static string HelpMessage_RunProtocolNotSelectedMessage {
            get {
                return ResourceManager.GetString("HelpMessage_RunProtocolNotSelectedMessage", resourceCulture);
            }
        }
    }
}
