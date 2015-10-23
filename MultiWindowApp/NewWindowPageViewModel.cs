using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiWindowApp
{
    class NewWindowPageViewModel
    {
        public ReadOnlyReactiveProperty<int> Count { get; }

        public NewWindowPageViewModel()
        {
            this.Count = Counter.Instance.ObserveProperty(x => x.Count)
                .ToReadOnlyReactiveProperty(eventScheduler: new SynchronizationContextScheduler(SynchronizationContext.Current));
        }
    }
}
