using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices2.Dictionary.ConnectToPlayer
{
    public class Player
    {
        public string name;
        public int id;

        public Player(int id)
        {
            this.id = id;
        }

    }
    public class Main : MonoBehaviour
    {
        public Dictionary<int, Player> playerDictionary = new Dictionary<int, Player>();
        // Start is called before the first frame update
        void Start()
        {
            Player p1 = new Player(1);
            p1.name = "Jimmy";
            Player p2 = new Player(200);
            p2.name = "Kayle";
            Player p3 = new Player(9);
            p3.name = "Yen";


            playerDictionary.Add(p1.id, p1);
            playerDictionary.Add(p2.id, p2);
            playerDictionary.Add(p3.id, p3);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var player = playerDictionary[200];
                Debug.Log("player name " + player.name);
            }
        }
    }
}

