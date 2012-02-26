﻿//-------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Appccelerate">
//   Copyright (c) 2008-2012
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.IStateMachine`2.#FirePriority(!1,System.Object[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.IStateMachine`2.#Fire(!1,System.Object[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "1#", Scope = "member", Target = "Appccelerate.StateMachine.IExtension`2.#InitializingStateMachine(Appccelerate.StateMachine.IStateMachineInformation`2<!0,!1>,!0&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "3#", Scope = "member", Target = "Appccelerate.StateMachine.IExtension`2.#HandlingTransitionException(Appccelerate.StateMachine.IStateMachineInformation`2<!0,!1>,Appccelerate.StateMachine.Internals.ITransition`2<!0,!1>,Appccelerate.StateMachine.Internals.ITransitionContext`2<!0,!1>,System.Exception&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "3#", Scope = "member", Target = "Appccelerate.StateMachine.IExtension`2.#HandlingGuardException(Appccelerate.StateMachine.IStateMachineInformation`2<!0,!1>,Appccelerate.StateMachine.Internals.ITransition`2<!0,!1>,Appccelerate.StateMachine.Internals.ITransitionContext`2<!0,!1>,System.Exception&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "3#", Scope = "member", Target = "Appccelerate.StateMachine.IExtension`2.#HandlingExitActionException(Appccelerate.StateMachine.IStateMachineInformation`2<!0,!1>,Appccelerate.StateMachine.Internals.IState`2<!0,!1>,Appccelerate.StateMachine.Internals.IStateContext`2<!0,!1>,System.Exception&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "3#", Scope = "member", Target = "Appccelerate.StateMachine.IExtension`2.#HandlingEntryActionException(Appccelerate.StateMachine.IStateMachineInformation`2<!0,!1>,Appccelerate.StateMachine.Internals.IState`2<!0,!1>,Appccelerate.StateMachine.Internals.IStateContext`2<!0,!1>,System.Exception&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1007:UseGenericsWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.IExtension`2.#FiringEvent(Appccelerate.StateMachine.IStateMachineInformation`2<!0,!1>,!1&,System.Object&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.StateMachine.IExtension`2.#FiringEvent(Appccelerate.StateMachine.IStateMachineInformation`2<!0,!1>,!1&,System.Object&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "1#", Scope = "member", Target = "Appccelerate.StateMachine.IExtension`2.#FiringEvent(Appccelerate.StateMachine.IStateMachineInformation`2<!0,!1>,!1&,System.Object&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "In", Scope = "member", Target = "Appccelerate.StateMachine.IStateMachine`2.#In(!0)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Stop", Scope = "member", Target = "Appccelerate.StateMachine.IStateMachine`2.#Stop()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "On", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IEventSyntax`2.#On(!1)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "If", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IIfOrOtherwiseSyntax`2.#If(System.Func`1<System.Boolean>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "If", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IIfOrOtherwiseSyntax`2.#If(System.Func`2<System.Object[],System.Boolean>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "If", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IIfOrOtherwiseSyntax`2.#If`1(System.Func`2<!!0,System.Boolean>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "GoTo", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IIfSyntax`2.#Goto(!0)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "GoTo", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IOnSyntax`2.#Goto(!0)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "If", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IOnSyntax`2.#If(System.Func`1<System.Boolean>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "If", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IOnSyntax`2.#If(System.Func`2<System.Object[],System.Boolean>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "If", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IOnSyntax`2.#If`1(System.Func`2<!!0,System.Boolean>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "GoTo", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IOtherwiseSyntax`2.#Goto(!0)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Exit", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IState`2.#Exit(Appccelerate.StateMachine.Internals.IStateContext`2<!0,!1>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IStateContext`2.#GetRecords()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IState`2.#Fire(Appccelerate.StateMachine.Internals.ITransitionContext`2<!0,!1>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "Appccelerate.StateMachine.Internals.IStateDictionary`2")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.Internals.IStateDictionary`2.#GetStates()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.Internals.ITransition`2.#Fire(Appccelerate.StateMachine.Internals.ITransitionContext`2<!0,!1>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Appccelerate.StateMachine.Internals.State`2.#ExecuteEntryAction(Appccelerate.StateMachine.Internals.IActionHolder,Appccelerate.StateMachine.Internals.IStateContext`2<!0,!1>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Appccelerate.StateMachine.Internals.State`2.#ExecuteExitAction(Appccelerate.StateMachine.Internals.IActionHolder,Appccelerate.StateMachine.Internals.IStateContext`2<!0,!1>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "Appccelerate.StateMachine.Internals.StateDictionary`2")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.Internals.StateMachine`2.#Fire(!1)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.Internals.StateMachine`2.#Fire(!1,System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Appccelerate.StateMachine.Internals.Transition`2.#PerformActions(System.Object,Appccelerate.StateMachine.Internals.ITransitionContext`2<!0,!1>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Appccelerate.StateMachine.Internals.Transition`2.#ShouldFire(System.Object,Appccelerate.StateMachine.Internals.ITransitionContext`2<!0,!1>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "Appccelerate.StateMachine.Internals.TransitionDictionary`2")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.Internals.TransitionDictionary`2.#GetTransitions()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Appccelerate.StateMachine.Internals.TransitionDictionary`2+TransitionInfo")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Ed", Scope = "type", Target = "Appccelerate.StateMachine.Reports.YEdStateMachineReportGenerator`2")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.IStateMachine`2.#Fire(!1)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.IStateMachine`2.#Fire(!1,System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.IStateMachine`2.#FirePriority(!1)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.IStateMachine`2.#FirePriority(!1,System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Appccelerate.StateMachine.Internals.ITransitionDictionary`2.#GetTransitions()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "Appccelerate.StateMachine.Internals.ITransitionDictionary`2")]