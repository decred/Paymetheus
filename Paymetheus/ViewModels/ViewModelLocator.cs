﻿// Copyright (c) 2016 The Decred developers
// Licensed under the ISC license.  See LICENSE file in the project root for full license information

using Paymetheus.Framework;

namespace Paymetheus.ViewModels
{
    public class ViewModelLocator
    {
        public static object SynchronizerViewModel => SingletonViewModelLocator.Resolve("Synchronizer");
        public static object ShellViewModel => SingletonViewModelLocator.Resolve("ShellView");
        public static object OverviewViewModel => SingletonViewModelLocator.Resolve("Overview");
        public static object CreateTransactionViewModel => SingletonViewModelLocator.Resolve("Send");
        public static object RequestViewModel => SingletonViewModelLocator.Resolve("Request");
        public static object TransactionHistoryViewModel => SingletonViewModelLocator.Resolve("History");
        public static object ScriptsViewModel => SingletonViewModelLocator.Resolve("Scripts");
        public static object StakeMiningViewModel => SingletonViewModelLocator.Resolve("StakeMining");
        public static object PurchaseTicketsViewModel => SingletonViewModelLocator.Resolve("PurchaseTickets");
    }
}
