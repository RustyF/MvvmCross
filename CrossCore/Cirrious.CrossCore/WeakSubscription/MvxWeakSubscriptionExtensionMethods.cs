// MvxWeakSubscriptionExtensionMethods.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using Cirrious.CrossCore.Core;

namespace Cirrious.CrossCore.WeakSubscription
{
    public static class MvxWeakSubscriptionExtensionMethods
    {
        public static MvxNotifyPropertyChangedEventSubscription WeakSubscribe(this INotifyPropertyChanged source,
                                                                              EventHandler<PropertyChangedEventArgs>
                                                                                  eventHandler)
        {
            return new MvxNotifyPropertyChangedEventSubscription(source, eventHandler);
        }

        public static MvxNamedNotifyPropertyChangedEventSubscription<T> WeakSubscribe<T>(this INotifyPropertyChanged source,
                                                                               Expression<Func<T>> property,
                                                                               EventHandler<PropertyChangedEventArgs>
                                                                                   eventHandler)
        {
            return new MvxNamedNotifyPropertyChangedEventSubscription<T>(source, property, eventHandler);
        }

        public static MvxNamedNotifyPropertyChangedEventSubscription<T> WeakSubscribe<T>(this INotifyPropertyChanged source,
                                                                               string property,
                                                                               EventHandler<PropertyChangedEventArgs>
                                                                                   eventHandler)
        {
            return new MvxNamedNotifyPropertyChangedEventSubscription<T>(source, property, eventHandler);
        }

        public static MvxNotifyCollectionChangedEventSubscription WeakSubscribe(this INotifyCollectionChanged source,
                                                                                EventHandler
                                                                                    <NotifyCollectionChangedEventArgs>
                                                                                    eventHandler)
        {
            return new MvxNotifyCollectionChangedEventSubscription(source, eventHandler);
        }

        public static MvxGeneralEventSubscription WeakSubscribe(this EventInfo eventInfo,
                                                                object source,
                                                                EventHandler<EventArgs> eventHandler)
        {
            return new MvxGeneralEventSubscription(source, eventInfo, eventHandler);
        }

        public static MvxValueEventSubscription<T> WeakSubscribe<T>(this EventInfo eventInfo,
                                                                    object source,
                                                                    EventHandler<MvxValueEventArgs<T>> eventHandler)
        {
            return new MvxValueEventSubscription<T>(source, eventInfo, eventHandler);
        }
    }
}