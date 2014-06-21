﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlarmWorkflow.Shared.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AlarmWorkflow.Shared.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The value &apos;{0}&apos; shall not be empty!.
        /// </summary>
        internal static string AssertionFailedExceptionNotEmpty {
            get {
                return ResourceManager.GetString("AssertionFailedExceptionNotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; shall not be null!.
        /// </summary>
        internal static string AssertionFailedExceptionNotNull {
            get {
                return ResourceManager.GetString("AssertionFailedExceptionNotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An assertion has failed.
        /// </summary>
        internal static string AssertionFailedGenericMessage {
            get {
                return ResourceManager.GetString("AssertionFailedGenericMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compilation process took {0} milliseconds..
        /// </summary>
        internal static string CustomScriptCompilationFinished {
            get {
                return ResourceManager.GetString("CustomScriptCompilationFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There were {0} errors/warnings during compilation of script &apos;{1}&apos;..
        /// </summary>
        internal static string CustomScriptCompilationWithErrorsWarnings {
            get {
                return ResourceManager.GetString("CustomScriptCompilationWithErrorsWarnings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The compilation of the script has failed. Please see the log for information..
        /// </summary>
        internal static string CustomScriptExecutionExceptionCompilationFailed {
            get {
                return ResourceManager.GetString("CustomScriptExecutionExceptionCompilationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while invoking the custom script..
        /// </summary>
        internal static string CustomScriptExecutionExceptionMessage {
            get {
                return ResourceManager.GetString("CustomScriptExecutionExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Either zero or more than one exported (public) type was found in the script. Valid scripts shall contain exactly one public, non-static type..
        /// </summary>
        internal static string CustomScriptExecutionExceptionNotExactlyOneExportedTypeFound {
            get {
                return ResourceManager.GetString("CustomScriptExecutionExceptionNotExactlyOneExportedTypeFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The script file was not found! Please check it exists..
        /// </summary>
        internal static string CustomScriptExecutionExceptionScriptFileNotFound {
            get {
                return ResourceManager.GetString("CustomScriptExecutionExceptionScriptFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The script function has an invalid signature. The script function shall have the following signature: &apos;public static string Function(object graph)&apos;..
        /// </summary>
        internal static string CustomScriptExecutionExceptionScriptFunctionMethodHasWrongSignature {
            get {
                return ResourceManager.GetString("CustomScriptExecutionExceptionScriptFunctionMethodHasWrongSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was no script function found! The script function shall have the following signature: &apos;public static string Function(object graph)&apos;..
        /// </summary>
        internal static string CustomScriptExecutionExceptionScriptFunctionNotFound {
            get {
                return ResourceManager.GetString("CustomScriptExecutionExceptionScriptFunctionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception was thrown by the script; it did not finish sucessfully..
        /// </summary>
        internal static string CustomScriptExecutionExceptionScriptInvocationException {
            get {
                return ResourceManager.GetString("CustomScriptExecutionExceptionScriptInvocationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Undefined reason. This indicates an internal error. Please report.).
        /// </summary>
        internal static string CustomScriptExecutionExceptionUndefined {
            get {
                return ResourceManager.GetString("CustomScriptExecutionExceptionUndefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Script file could not be executed because it contained errors. Please check the log file for details.).
        /// </summary>
        internal static string CustomScriptInvocationFailed {
            get {
                return ResourceManager.GetString("CustomScriptInvocationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while invoking user-provided expression resolver. A default value will be used for this expression. Please see log for further information..
        /// </summary>
        internal static string ErrorWhileInvokingUserExpressionResolver {
            get {
                return ResourceManager.GetString("ErrorWhileInvokingUserExpressionResolver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expression &apos;{0}&apos; led to an unsupported member, thus it cannot be retrieved. Please revise this expression or remove it if not needed..
        /// </summary>
        internal static string ExpressionNotSupportedExceptionMessage {
            get {
                return ResourceManager.GetString("ExpressionNotSupportedExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not parse setting value. Maybe it is ill-formed. The instance will have no items. See log for further information..
        /// </summary>
        internal static string FDResourceConfigurationParseError {
            get {
                return ResourceManager.GetString("FDResourceConfigurationParseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file path must be in absolute format!.
        /// </summary>
        internal static string FileNameMustBeAbsolute {
            get {
                return ResourceManager.GetString("FileNameMustBeAbsolute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The desired file {0} doesn&apos;t exist. The program will not be executed! Please check your configuration..
        /// </summary>
        internal static string FileNotExists {
            get {
                return ResourceManager.GetString("FileNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The printing queue &apos;{0}&apos; is not valid. Printing will be canceled. Please check if PrintServer and PrinterName are properly configured..
        /// </summary>
        internal static string GdiPrinterPrintingQueueIsNotValid {
            get {
                return ResourceManager.GetString("GdiPrinterPrintingQueueIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while printing using GDI..
        /// </summary>
        internal static string GdiPrinterPrintTaskException {
            get {
                return ResourceManager.GetString("GdiPrinterPrintTaskException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Done printing of page {0}..
        /// </summary>
        internal static string PrintingDone {
            get {
                return ResourceManager.GetString("PrintingDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The copy count must be greater than zero!.
        /// </summary>
        internal static string PrintingQueueCopyCountMustBeGreaterThanZero {
            get {
                return ResourceManager.GetString("PrintingQueueCopyCountMustBeGreaterThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The printing queue must have a valid name!.
        /// </summary>
        internal static string PrintingQueueNameMustNotBeEmpty {
            get {
                return ResourceManager.GetString("PrintingQueueNameMustNotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encountered invalid copy count for printing queue &apos;{0}&apos;. Using default of &apos;{1}&apos; for this queue..
        /// </summary>
        internal static string PrintingQueueParseErrorCopyCountIsInvalid {
            get {
                return ResourceManager.GetString("PrintingQueueParseErrorCopyCountIsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ignoring printing queue with invalid name. Please check configuration!.
        /// </summary>
        internal static string PrintingQueueParseErrorNameIsInvalid {
            get {
                return ResourceManager.GetString("PrintingQueueParseErrorNameIsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finished iteration..
        /// </summary>
        internal static string PrintIterationEnd {
            get {
                return ResourceManager.GetString("PrintIterationEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Beginning print iteration {0}/{1}....
        /// </summary>
        internal static string PrintIterationStart {
            get {
                return ResourceManager.GetString("PrintIterationStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while printing page &apos;{0}&apos;. The printing task will be aborted..
        /// </summary>
        internal static string PrintTaskPrintPageException {
            get {
                return ResourceManager.GetString("PrintTaskPrintPageException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process data event: {0}.
        /// </summary>
        internal static string ProcessDataEvent {
            get {
                return ResourceManager.GetString("ProcessDataEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process error event: {0}.
        /// </summary>
        internal static string ProcessErrorEvent {
            get {
                return ResourceManager.GetString("ProcessErrorEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not start executable file &apos;{0}&apos; because of an exception. See log for further information..
        /// </summary>
        internal static string ProcessWrapperStartError {
            get {
                return ResourceManager.GetString("ProcessWrapperStartError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Program &apos;{0}&apos; has finished with exit code {1}..
        /// </summary>
        internal static string ProgramFinished {
            get {
                return ResourceManager.GetString("ProgramFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting program &apos;{0}&apos; with arguments &apos;{1}&apos;....
        /// </summary>
        internal static string ProgramStart {
            get {
                return ResourceManager.GetString("ProgramStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registered service type &apos;{0}&apos; (instance type: {1})..
        /// </summary>
        internal static string ServiceProviderRegisteredService {
            get {
                return ResourceManager.GetString("ServiceProviderRegisteredService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finished scan of setting display configurations in {0} milliseconds..
        /// </summary>
        internal static string SettingsManagerScanSettingsDisplayConfigurationFinished {
            get {
                return ResourceManager.GetString("SettingsManagerScanSettingsDisplayConfigurationFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finished scan of setting definitions in {0} milliseconds..
        /// </summary>
        internal static string SettingsManagerScanSettingsFinished {
            get {
                return ResourceManager.GetString("SettingsManagerScanSettingsFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user.settings is malformed! Personalized user settings cannot be loaded. Please review your file. If you are sure that you haven&apos;t done any custom modifications to this file, please contact the team..
        /// </summary>
        internal static string SettingsManagerUserSettingsFileInvalid {
            get {
                return ResourceManager.GetString("SettingsManagerUserSettingsFileInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User settings loaded..
        /// </summary>
        internal static string SettingsManagerUserSettingsFileLoaded {
            get {
                return ResourceManager.GetString("SettingsManagerUserSettingsFileLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User settings file does not exist; skipping..
        /// </summary>
        internal static string SettingsManagerUserSettingsFileSkip {
            get {
                return ResourceManager.GetString("SettingsManagerUserSettingsFileSkip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The selected printer does not support printing more than {0} copies natively (you requested: {1}). Using alternative method of printing copies..
        /// </summary>
        internal static string UsedPrinterDoesNotSupportThatMuchCopies {
            get {
                return ResourceManager.GetString("UsedPrinterDoesNotSupportThatMuchCopies", resourceCulture);
            }
        }
    }
}
