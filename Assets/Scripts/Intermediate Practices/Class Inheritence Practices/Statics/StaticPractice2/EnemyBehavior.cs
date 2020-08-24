﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IntermediatePractices.Inheritance.Statics.Practice2
{
    public class EnemyBehavior : MonoBehaviour
    {
        private UIManager _ui;
        public void OnEnable()
        {
            SpawnManager.enemyCount++;
            _ui = GameObject.Find("UIManager").GetComponent<UIManager>();
            _ui.UpdateEnemyCount();
            Die();
        }

        public void OnDisable()
        {
            SpawnManager.enemyCount--;
            _ui.UpdateEnemyCount();
        }
        void Die()
        {
            Destroy(this.gameObject, Random.Range(2, 6));
        }
    }

}
