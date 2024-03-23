using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Providers
{
    public abstract class ProviderBase<T> : IProviderBase<T> where T : class
    {
        private static readonly char[] separator = [' '];

        public virtual T Initialize(string args)
        {
            T type = default;
            ArgumentException.ThrowIfNullOrWhiteSpace(args);
            string[] values = args.Split(separator, StringSplitOptions.TrimEntries);
            return Create(type, values);
        }

        public virtual T Create(T type, string[] values)
        {
            return type;
        }
    }
}
