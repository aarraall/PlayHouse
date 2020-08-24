using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.AbstractClasses.Interfaces
{
    public interface IDamagable<T>
    {
        int Health { get; set; }

        void Damage(T damageAmount);
    }
}

