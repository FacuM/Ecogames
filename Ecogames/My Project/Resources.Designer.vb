﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Ecogames.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Crossword.
        '''</summary>
        Friend ReadOnly Property ActivityType_Crossword() As String
            Get
                Return ResourceManager.GetString("ActivityType_Crossword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 0.
        '''</summary>
        Friend ReadOnly Property ActivityType_Crossword_ID() As String
            Get
                Return ResourceManager.GetString("ActivityType_Crossword_ID", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Hangman.
        '''</summary>
        Friend ReadOnly Property ActivityType_Hangman() As String
            Get
                Return ResourceManager.GetString("ActivityType_Hangman", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 1.
        '''</summary>
        Friend ReadOnly Property ActivityType_Hangman_ID() As String
            Get
                Return ResourceManager.GetString("ActivityType_Hangman_ID", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Open questions.
        '''</summary>
        Friend ReadOnly Property ActivityType_Question_Open() As String
            Get
                Return ResourceManager.GetString("ActivityType_Question_Open", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 2.
        '''</summary>
        Friend ReadOnly Property ActivityType_Question_Open_ID() As String
            Get
                Return ResourceManager.GetString("ActivityType_Question_Open_ID", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Closed questions.
        '''</summary>
        Friend ReadOnly Property ActivityType_Question_Opts() As String
            Get
                Return ResourceManager.GetString("ActivityType_Question_Opts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 3.
        '''</summary>
        Friend ReadOnly Property ActivityType_Question_Opts_ID() As String
            Get
                Return ResourceManager.GetString("ActivityType_Question_Opts_ID", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property Clock_tac() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("Clock_tac", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property Clock_tic() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("Clock_tic", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property Completed() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("Completed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Reference.
        '''</summary>
        Friend ReadOnly Property Crossword_ColumnHeader_ReferenceText() As String
            Get
                Return ResourceManager.GetString("Crossword_ColumnHeader_ReferenceText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Welcome to the clean environment debug mode, it&apos;s nice to see you here!
        '''
        '''In this mode, all of the settings (app settings, activities, etc.) are deleted each time the main form is launched, that is, each time that SplashScreen.Load occurs.
        '''
        '''If you&apos;re testing a translations set, you might not want the language to go back to defaults. To prevent such behavior, make sure that you&apos;re building with the following constants defined: DEBUG, DEBUG_CLEAN=True and KEEP_LANG=True..
        '''</summary>
        Friend ReadOnly Property Debug_CleanEnvStartup() As String
            Get
                Return ResourceManager.GetString("Debug_CleanEnvStartup", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property drawing() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("drawing", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No secret word entered, you won&apos;t be able to recover your password. Continue anyways?.
        '''</summary>
        Friend ReadOnly Property FirstRun_EmptySecretWordWarn() As String
            Get
                Return ResourceManager.GetString("FirstRun_EmptySecretWordWarn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The passwords do not match..
        '''</summary>
        Friend ReadOnly Property FirstRun_PasswordsDontMatch() As String
            Get
                Return ResourceManager.GetString("FirstRun_PasswordsDontMatch", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The password is too short..
        '''</summary>
        Friend ReadOnly Property FirstRun_PasswordTooShort() As String
            Get
                Return ResourceManager.GetString("FirstRun_PasswordTooShort", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sign up.
        '''</summary>
        Friend ReadOnly Property FirstRun_Text() As String
            Get
                Return ResourceManager.GetString("FirstRun_Text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You must type a name..
        '''</summary>
        Friend ReadOnly Property FirstRun_UsernameRequired() As String
            Get
                Return ResourceManager.GetString("FirstRun_UsernameRequired", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error.
        '''</summary>
        Friend ReadOnly Property General_Error_Title() As String
            Get
                Return ResourceManager.GetString("General_Error_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Information.
        '''</summary>
        Friend ReadOnly Property General_Info_Title() As String
            Get
                Return ResourceManager.GetString("General_Info_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Warning.
        '''</summary>
        Friend ReadOnly Property General_Warn_Title() As String
            Get
                Return ResourceManager.GetString("General_Warn_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to English.
        '''</summary>
        Friend ReadOnly Property Language_English() As String
            Get
                Return ResourceManager.GetString("Language_English", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Español.
        '''</summary>
        Friend ReadOnly Property Language_Spanish() As String
            Get
                Return ResourceManager.GetString("Language_Spanish", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You can&apos;t keep trying, the application will now close..
        '''</summary>
        Friend ReadOnly Property Login_RecoveryMode_NoAttempts() As String
            Get
                Return ResourceManager.GetString("Login_RecoveryMode_NoAttempts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to To recover your password, type the secret word in the box below..
        '''</summary>
        Friend ReadOnly Property Login_RecoveryModeHelper() As String
            Get
                Return ResourceManager.GetString("Login_RecoveryModeHelper", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to That&apos;s not the right word, {0} attempts remaining..
        '''</summary>
        Friend ReadOnly Property Login_RecoveryModeWrongWord() As String
            Get
                Return ResourceManager.GetString("Login_RecoveryModeWrongWord", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sign in.
        '''</summary>
        Friend ReadOnly Property Login_Text() As String
            Get
                Return ResourceManager.GetString("Login_Text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Recovery.
        '''</summary>
        Friend ReadOnly Property Login_Text_RecoveryMode() As String
            Get
                Return ResourceManager.GetString("Login_Text_RecoveryMode", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The password you entered is incorrect, please try again..
        '''</summary>
        Friend ReadOnly Property Login_WrongPassword() As String
            Get
                Return ResourceManager.GetString("Login_WrongPassword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property Logo() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Logo", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to To complete your request, all of the open forms must be closed. Close everything right now?.
        '''</summary>
        Friend ReadOnly Property NotifyIcon_LanguageResetWarn() As String
            Get
                Return ResourceManager.GetString("NotifyIcon_LanguageResetWarn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Ecogames.
        '''</summary>
        Friend ReadOnly Property NotifyIcon_Text() As String
            Get
                Return ResourceManager.GetString("NotifyIcon_Text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property Perfect() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("Perfect", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Activities.
        '''</summary>
        Friend ReadOnly Property Play_Activities_Text() As String
            Get
                Return ResourceManager.GetString("Play_Activities_Text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Great! You got a row done..
        '''</summary>
        Friend ReadOnly Property Play_Crossword_RowDone() As String
            Get
                Return ResourceManager.GetString("Play_Crossword_RowDone", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You got {0}/{1} points (a {2}%)..
        '''</summary>
        Friend ReadOnly Property Play_General_CompletionLevel() As String
            Get
                Return ResourceManager.GetString("Play_General_CompletionLevel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to (empty).
        '''</summary>
        Friend ReadOnly Property Play_General_EmptyAnswerDescriptor() As String
            Get
                Return ResourceManager.GetString("Play_General_EmptyAnswerDescriptor", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The game begins!.
        '''</summary>
        Friend ReadOnly Property Play_General_GameBegins() As String
            Get
                Return ResourceManager.GetString("Play_General_GameBegins", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You didn&apos;t complete the activity, do you really wanna quit anyways?.
        '''</summary>
        Friend ReadOnly Property Play_General_IncompleteActivityWarn() As String
            Get
                Return ResourceManager.GetString("Play_General_IncompleteActivityWarn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You ran out of tries..
        '''</summary>
        Friend ReadOnly Property Play_General_NoAttempts() As String
            Get
                Return ResourceManager.GetString("Play_General_NoAttempts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You didn&apos;t get any points..
        '''</summary>
        Friend ReadOnly Property Play_General_NoCompletion() As String
            Get
                Return ResourceManager.GetString("Play_General_NoCompletion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Congratulations! You&apos;ve completed the activity with a perfect score..
        '''</summary>
        Friend ReadOnly Property Play_General_PerfectScore() As String
            Get
                Return ResourceManager.GetString("Play_General_PerfectScore", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Perfect!.
        '''</summary>
        Friend ReadOnly Property Play_General_PerfectScore_Trim() As String
            Get
                Return ResourceManager.GetString("Play_General_PerfectScore_Trim", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0} seconds remaining..
        '''</summary>
        Friend ReadOnly Property Play_General_RemainingSeconds_Plural() As String
            Get
                Return ResourceManager.GetString("Play_General_RemainingSeconds_Plural", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0} second remaining..
        '''</summary>
        Friend ReadOnly Property Play_General_RemainingSeconds_Singular() As String
            Get
                Return ResourceManager.GetString("Play_General_RemainingSeconds_Singular", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Right!.
        '''</summary>
        Friend ReadOnly Property Play_General_RightAnswer() As String
            Get
                Return ResourceManager.GetString("Play_General_RightAnswer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Oh, you ran out of time!.
        '''</summary>
        Friend ReadOnly Property Play_General_Timedout() As String
            Get
                Return ResourceManager.GetString("Play_General_Timedout", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Oh, that&apos;s wrong!.
        '''</summary>
        Friend ReadOnly Property Play_General_WrongAnswer() As String
            Get
                Return ResourceManager.GetString("Play_General_WrongAnswer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Wrong! {0} attempts remaining..
        '''</summary>
        Friend ReadOnly Property Play_Hangman_Wrong_RemainingAttempts() As String
            Get
                Return ResourceManager.GetString("Play_Hangman_Wrong_RemainingAttempts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Your answer was empty and you didn&apos;t get any points ({0}% completed)..
        '''</summary>
        Friend ReadOnly Property Play_Question_General_AutoEvalEmpty() As String
            Get
                Return ResourceManager.GetString("Play_Question_General_AutoEvalEmpty", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You didn&apos;t answer, do you wanna continue anyways?.
        '''</summary>
        Friend ReadOnly Property Play_Question_General_AutoEvalEmptyAnswerWarn() As String
            Get
                Return ResourceManager.GetString("Play_Question_General_AutoEvalEmptyAnswerWarn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Great! You got a {0}%..
        '''</summary>
        Friend ReadOnly Property Play_Question_General_AutoEvalRegular() As String
            Get
                Return ResourceManager.GetString("Play_Question_General_AutoEvalRegular", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Excellent, keep it up! You achieved a {0}%..
        '''</summary>
        Friend ReadOnly Property Play_Question_General_AutoEvalRight() As String
            Get
                Return ResourceManager.GetString("Play_Question_General_AutoEvalRight", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Oh! You just got a {0}%..
        '''</summary>
        Friend ReadOnly Property Play_Question_General_AutoEvalWrong() As String
            Get
                Return ResourceManager.GetString("Play_Question_General_AutoEvalWrong", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You didn&apos;t get any point! {0}% completed..
        '''</summary>
        Friend ReadOnly Property Play_Question_Open_AutoEvalNoScore() As String
            Get
                Return ResourceManager.GetString("Play_Question_Open_AutoEvalNoScore", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Your answer: 
        '''{0}
        '''
        '''Expected answer: 
        '''{1}.
        '''</summary>
        Friend ReadOnly Property Play_Question_Open_AutoEvalResult() As String
            Get
                Return ResourceManager.GetString("Play_Question_Open_AutoEvalResult", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please, wait until your answer is verified by your teacher..
        '''</summary>
        Friend ReadOnly Property Play_Question_Open_NoAutoEvalInfo() As String
            Get
                Return ResourceManager.GetString("Play_Question_Open_NoAutoEvalInfo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Thanks for replying!.
        '''</summary>
        Friend ReadOnly Property Play_Question_Open_NoAutoEvalThanks() As String
            Get
                Return ResourceManager.GetString("Play_Question_Open_NoAutoEvalThanks", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You can reply by selecting all of the right answers..
        '''</summary>
        Friend ReadOnly Property Play_Question_Opts_GeneralHelp() As String
            Get
                Return ResourceManager.GetString("Play_Question_Opts_GeneralHelp", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The automatic verification isn&apos;t totally accurante and might cause unwanted results..
        '''</summary>
        Friend ReadOnly Property Question_Open_AutoEvalWarn() As String
            Get
                Return ResourceManager.GetString("Question_Open_AutoEvalWarn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Delete.
        '''</summary>
        Friend ReadOnly Property Question_Opts_DelMode() As String
            Get
                Return ResourceManager.GetString("Question_Opts_DelMode", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You&apos;ll delete this option, are you sure?.
        '''</summary>
        Friend ReadOnly Property Question_Opts_Empty() As String
            Get
                Return ResourceManager.GetString("Question_Opts_Empty", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0}
        '''
        '''When you&apos;re done, click &quot;Save&quot;..
        '''</summary>
        Friend ReadOnly Property Question_Opts_GeneralHelp() As String
            Get
                Return ResourceManager.GetString("Question_Opts_GeneralHelp", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modify.
        '''</summary>
        Friend ReadOnly Property Question_Opts_ModMode() As String
            Get
                Return ResourceManager.GetString("Question_Opts_ModMode", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;New answer&gt;.
        '''</summary>
        Friend ReadOnly Property Question_Opts_NewAnswer() As String
            Get
                Return ResourceManager.GetString("Question_Opts_NewAnswer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to To set up the answers, click &quot;Next&quot;..
        '''</summary>
        Friend ReadOnly Property Question_Opts_NextActionHelp() As String
            Get
                Return ResourceManager.GetString("Question_Opts_NextActionHelp", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to To add an option, click &quot;Add&quot;..
        '''</summary>
        Friend ReadOnly Property Question_Opts_NextAnswerHelp() As String
            Get
                Return ResourceManager.GetString("Question_Opts_NextAnswerHelp", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Saved.
        '''</summary>
        Friend ReadOnly Property Question_Saved() As String
            Get
                Return ResourceManager.GetString("Question_Saved", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add.
        '''</summary>
        Friend ReadOnly Property Queston_Add() As String
            Get
                Return ResourceManager.GetString("Queston_Add", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property Regular() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("Regular", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property Right() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("Right", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Activity.
        '''</summary>
        Friend ReadOnly Property Settings_Activity() As String
            Get
                Return ResourceManager.GetString("Settings_Activity", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The entered value &quot;{0}&quot; is reserved by the system..
        '''</summary>
        Friend ReadOnly Property Settings_Crossword_IllegalStringException() As String
            Get
                Return ResourceManager.GetString("Settings_Crossword_IllegalStringException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No references are set..
        '''</summary>
        Friend ReadOnly Property Settings_Crossword_NoReference() As String
            Get
                Return ResourceManager.GetString("Settings_Crossword_NoReference", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Delete all.
        '''</summary>
        Friend ReadOnly Property Settings_General_DeleteAllText() As String
            Get
                Return ResourceManager.GetString("Settings_General_DeleteAllText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Stop there! You&apos;ll delete everything, continue?.
        '''</summary>
        Friend ReadOnly Property Settings_General_DeleteAllWarn() As String
            Get
                Return ResourceManager.GetString("Settings_General_DeleteAllWarn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Delete.
        '''</summary>
        Friend ReadOnly Property Settings_General_DeleteText() As String
            Get
                Return ResourceManager.GetString("Settings_General_DeleteText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An internal error has occured..
        '''</summary>
        Friend ReadOnly Property Settings_General_Err() As String
            Get
                Return ResourceManager.GetString("Settings_General_Err", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The index {0} of {1} isn&apos;t a number..
        '''</summary>
        Friend ReadOnly Property Settings_General_Err_Index() As String
            Get
                Return ResourceManager.GetString("Settings_General_Err_Index", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;New activity&gt;.
        '''</summary>
        Friend ReadOnly Property Settings_General_NewActivity() As String
            Get
                Return ResourceManager.GetString("Settings_General_NewActivity", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No activities found..
        '''</summary>
        Friend ReadOnly Property Settings_General_NoActivities() As String
            Get
                Return ResourceManager.GetString("Settings_General_NoActivities", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You&apos;ll loose your changes, do you wanna quit anyways?.
        '''</summary>
        Friend ReadOnly Property Settings_General_UnsavedWarn() As String
            Get
                Return ResourceManager.GetString("Settings_General_UnsavedWarn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Settings.
        '''</summary>
        Friend ReadOnly Property Settings_Text() As String
            Get
                Return ResourceManager.GetString("Settings_Text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property Wrong() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("Wrong", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
