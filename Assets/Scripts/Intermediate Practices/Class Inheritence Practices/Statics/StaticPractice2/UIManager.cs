using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace IntermediatePractices.Inheritance.Statics.Practice2
{
    public class UIManager : MonoBehaviour
    {
        public Text activeEnemiesText;

        public void UpdateEnemyCount()
        {
            activeEnemiesText.text = "Active enemies : " + SpawnManager.enemyCount;
        }
    }

}
