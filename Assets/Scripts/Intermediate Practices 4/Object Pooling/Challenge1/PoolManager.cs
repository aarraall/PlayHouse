using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Intermediate_Practices_4.Object_Pooling.Challenge1
{
    [RequireComponent(typeof(PoolManager))]
    public class PoolManager : MonoBehaviour
    {
        private static PoolManager _instance;
        public static PoolManager Instance
        {
            get
            {
                if (_instance == null)
                    Debug.LogError("Instance is null");
                return _instance;
            }
        }

        [SerializeField]
        private GameObject bulletContainer;
        [SerializeField]
        private GameObject bulletPrefab;
        [SerializeField]
        private List<GameObject> bulletPool;
    
        private void Awake()
        {
            _instance = this;
        }
        private void Start()
        {
            bulletPool = GenerateBullets(10);
        }
        private List<GameObject> GenerateBullets(int amountOfBullets) 
        {
            for(int i = 0; i < amountOfBullets; i++)
            {
                GameObject bullet = Instantiate(bulletPrefab);
                bullet.transform.parent = bulletContainer.transform;
                bullet.SetActive(false);
                bulletPool.Add(bullet);
            }
            return bulletPool;
        }
        public GameObject RequestBullet()
        {
            foreach (GameObject bullet in bulletPool.Where(bullet => bullet.activeInHierarchy == false))
            {
                bullet.SetActive(true);
                return bullet;
            }

            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.parent = bulletContainer.transform;
            newBullet.SetActive(false);
            bulletPool.Add(newBullet);

            return newBullet;
        }
    }
}
