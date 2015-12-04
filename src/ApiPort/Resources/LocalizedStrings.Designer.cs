﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiPort.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    //[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class LocalizedStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        //[global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizedStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ApiPort.Resources.LocalizedStrings", typeof(LocalizedStrings).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Analyze.
        /// </summary>
        public static string Analyze {
            get {
                return ResourceManager.GetString("Analyze", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to API Portability Analyzer.
        /// </summary>
        public static string ApplicationName {
            get {
                return ResourceManager.GetString("ApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Available Aliases:.
        /// </summary>
        public static string AvailableAliases {
            get {
                return ResourceManager.GetString("AvailableAliases", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Available output formats:.
        /// </summary>
        public static string AvailableOutputFormats {
            get {
                return ResourceManager.GetString("AvailableOutputFormats", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Available Targets:.
        /// </summary>
        public static string AvailableTargets {
            get {
                return ResourceManager.GetString("AvailableTargets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analyzes specified files/directories for IL and determines the APIs that are used. This information is analyzed 
        ///for portability concerns or known breaking changes (depending on input parameters) and returns a report that 
        ///gives a summary of issues and possible steps forward.
        ///
        ///  -f, --file VALUE             [Required] Path to assembly file or directory of
        ///                                 assemblies.
        ///  -o, --out VALUE              Output file name
        ///  -d, --description VALUE      Description of the subm [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CmdAnalyzeHelp {
            get {
                return ResourceManager.GetString("CmdAnalyzeHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provides an interactive console search for APIs. Useful to find the docid of a specific API.
        /// </summary>
        public static string CmdDocId {
            get {
                return ResourceManager.GetString("CmdDocId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies a json file defining assemblies that should not be analyzed for specific targets while analyzing breaking changes. This can be useful for excluding assemblies that are known to not regress on certain .NET Framework versions due to breaking changes. Note that, currently, this parameter only affects breaking change analysis; not portability analysis..
        /// </summary>
        public static string CmdHelpIgnoreAssembliesFile {
            get {
                return ResourceManager.GetString("CmdHelpIgnoreAssembliesFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not use the standard assembly ignore list when analyzing breaking changes. The default ignore list can be found at KnownSafeBreaks.json.
        /// </summary>
        public static string CmdHelpNoDefaultIgnoreFile {
            get {
                return ResourceManager.GetString("CmdHelpNoDefaultIgnoreFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calculate breaking changes on full .NET Framework.
        /// </summary>
        public static string CmdHelpShowBreakingChanges {
            get {
                return ResourceManager.GetString("CmdHelpShowBreakingChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calculate non-portable APIs.
        /// </summary>
        public static string CmdHelpShowNonPortableApis {
            get {
                return ResourceManager.GetString("CmdHelpShowNonPortableApis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies a breaking change (by ID) to suppress during breaking change analysis. Any breaking changes with IDs specified for suppression will not be reported..
        /// </summary>
        public static string CmdHelpSuppressBreakingChange {
            get {
                return ResourceManager.GetString("CmdHelpSuppressBreakingChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieves a list of output formats that are available in which to receive reports
        ///
        ///  -h, -?, --help             Show help.
        /// </summary>
        public static string CmdListOutputFormats {
            get {
                return ResourceManager.GetString("CmdListOutputFormats", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieves a list of targets available to analyze assemblies against
        ///
        ///  -h, -?, --help             Show help.
        /// </summary>
        public static string CmdListTargets {
            get {
                return ResourceManager.GetString("CmdListTargets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Description.
        /// </summary>
        public static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Description of the submission.
        /// </summary>
        public static string DescriptionHelp {
            get {
                return ResourceManager.GetString("DescriptionHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analyze request file output does not support this operation.
        /// </summary>
        public static string FileOutputServiceNotSupported {
            get {
                return ResourceManager.GetString("FileOutputServiceNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft (R) {0} v{1}
        ///Copyright (C) Microsoft Corporation. All rights reserved.
        ///
        ///This tool analyzes .NET assemblies to determine possible problems moving between .NET platforms (such as
        ///Windows Store, desktop, Mono, .NET Core, etc) as well as between .NET Framework versions (ie 4.x-&gt;4.y).
        ///
        ///To learn more about how this tool works, including the data we are collecting, 
        ///go here - http://go.microsoft.com/fwlink/?LinkId=397652.
        /// </summary>
        public static string Header {
            get {
                return ResourceManager.GetString("Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid argument was passed in. Please check your command line parameters.
        ///{0}.
        /// </summary>
        public static string InvalidCommandLineArguments {
            get {
                return ResourceManager.GetString("InvalidCommandLineArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse ignore file &apos;{0}&apos;. Error details:
        ///{1}.
        /// </summary>
        public static string InvalidIgnoreFile {
            get {
                return ResourceManager.GetString("InvalidIgnoreFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to assembly file or directory of assemblies..
        /// </summary>
        public static string ListOfAssembliesToAnalyze {
            get {
                return ResourceManager.GetString("ListOfAssembliesToAnalyze", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use to see what output formats are supported for the generated report..
        /// </summary>
        public static string ListOutputFormats {
            get {
                return ResourceManager.GetString("ListOutputFormats", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use to see the available targets against which you can validate your assemblies.
        /// </summary>
        public static string ListTargets {
            get {
                return ResourceManager.GetString("ListTargets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you are running on the mono runtime, you must configure root certificates before using this application.  Please see http://www.mono-project.com/docs/faq/security/.
        /// </summary>
        public static string MonoWebRequestsFailure {
            get {
                return ResourceManager.GetString("MonoWebRequestsFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Notes on usage:.
        /// </summary>
        public static string NotesOnUsage {
            get {
                return ResourceManager.GetString("NotesOnUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output file name.
        /// </summary>
        public static string OutputFileName {
            get {
                return ResourceManager.GetString("OutputFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrote output to file:.
        /// </summary>
        public static string OutputWrittenTo {
            get {
                return ResourceManager.GetString("OutputWrittenTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replaced output file &quot;{0}&quot;.
        /// </summary>
        public static string OverwriteFile {
            get {
                return ResourceManager.GetString("OverwriteFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Done].
        /// </summary>
        public static string ProgressReportDone {
            get {
                return ResourceManager.GetString("ProgressReportDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Failed].
        /// </summary>
        public static string ProgressReportFailed {
            get {
                return ResourceManager.GetString("ProgressReportFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [In Progress{0}].
        /// </summary>
        public static string ProgressReportInProgress {
            get {
                return ResourceManager.GetString("ProgressReportInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The report output format.
        /// </summary>
        public static string ResultFormatHelp {
            get {
                return ResourceManager.GetString("ResultFormatHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Targets.
        /// </summary>
        public static string Targets {
            get {
                return ResourceManager.GetString("Targets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to - {0} [Version: {1}].
        /// </summary>
        public static string TargetsList {
            get {
                return ResourceManager.GetString("TargetsList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to - {0} ({1}).
        /// </summary>
        public static string TargetsListGrouped {
            get {
                return ResourceManager.GetString("TargetsListGrouped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to - {0}.
        /// </summary>
        public static string TargetsListNoVersion {
            get {
                return ResourceManager.GetString("TargetsListNoVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The target you want to check against..
        /// </summary>
        public static string TargetsToCheckAgainst {
            get {
                return ResourceManager.GetString("TargetsToCheckAgainst", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an unexpected error.  Please try again or contact NETAPIPort@Microsoft.com for help..
        /// </summary>
        public static string UnknownException {
            get {
                return ResourceManager.GetString("UnknownException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ; .
        /// </summary>
        public static string VersionListJoin {
            get {
                return ResourceManager.GetString("VersionListJoin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Versions marked with an asterisk (*) implies that these are default targets if none are submitted..
        /// </summary>
        public static string WhatAsteriskMeans {
            get {
                return ResourceManager.GetString("WhatAsteriskMeans", resourceCulture);
            }
        }
    }
}
