using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Interfaces
{
    public interface IGpsDependencyService
    {
        void OpenSettings();
        bool IsGpsEnable();
    }
}
