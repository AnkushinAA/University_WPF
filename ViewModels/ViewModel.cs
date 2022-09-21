using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace University_WPF.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            PropertyChangedEventHandler? handlers = PropertyChanged;
            if (handlers is null)
            {
                return;
            }

            Delegate[] invocation_list = handlers.GetInvocationList();

            PropertyChangedEventArgs arg = new(PropertyName);
            foreach (Delegate action in invocation_list)
            {
                if (action.Target is DispatcherObject disp_object)
                {
                    _ = disp_object.Dispatcher.Invoke(action, this, arg);
                }
                else
                {
                    _ = action.DynamicInvoke(this, arg);
                }
            }
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }

            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }
}
