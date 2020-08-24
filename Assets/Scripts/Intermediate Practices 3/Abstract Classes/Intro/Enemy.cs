using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IntermediatePractices3.AbstractClasses.Intro
{
    public abstract class Enemy : MonoBehaviour
    {
        public int speed;
        public int health;
        public int gems;

        public abstract void Attack();

        public virtual void Die()
        {
            Destroy(gameObject);
        }


    }

    public class MossGiant : Enemy
    {
        public override void Attack()
        {

        }

        public override void Die()
        {
            base.Die();
        }
    }
}

