using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Intermediate_Practices_4.Command_Pattern.Practice1.Interfaces
{
    public interface ICommand
    {
        void Execute();
        void Undue();
    }
}
