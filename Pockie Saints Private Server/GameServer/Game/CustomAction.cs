using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public interface ICustomAction
    {
        void Init();
        void Update();
        void Destroy();
        bool CanDestroy();
        bool OnTimer();
        int GetTime();

    }
}
