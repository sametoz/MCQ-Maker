using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Business.Helper
{
    public interface ICache
    {
        void Add(byte[] key, byte[] value);
        string Retrieve(string key);
    }
}
