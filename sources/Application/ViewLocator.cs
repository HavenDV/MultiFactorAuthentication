using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using MultiFactorAuthentication.ViewModels;

namespace MultiFactorAuthentication
{
    public class ViewLocator : IDataTemplate
    {
        public bool SupportsRecycling => false;

        public IControl Build(object data)
        {
            var fullName = data.GetType().FullName;
            if (fullName == null)
            {
                return new TextBlock { Text = "Full name of data type is null" };
            }

            var name = fullName.Replace("ViewModel", "View");
            var type = Type.GetType(name);
            if (type == null)
            {
                return new TextBlock { Text = $"Not Found: {name}" };
            }

            return Activator.CreateInstance(type) as Control ??
                   new TextBlock { Text = $"Invalid Type: {name}" };
        }

        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}