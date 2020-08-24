using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices4.ObjectPooling.Intro
{
    public class Bullet : MonoBehaviour
    {
        private void OnEnable()
        {
            StartCoroutine(Hide());
        }
        private IEnumerator Hide()
        {
            yield return new WaitForSeconds(1f);
            
            this.gameObject.SetActive(false);
        }
    }
}