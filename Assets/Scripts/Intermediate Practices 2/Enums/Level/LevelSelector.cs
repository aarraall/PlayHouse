using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public enum Difficulty
    {
        Easy,
        Normal, 
        Hard,
        Expert
    }
    public Difficulty difficulty;

    private void Start()
    {
        SceneManager.LoadScene((int)difficulty);
    }
}
