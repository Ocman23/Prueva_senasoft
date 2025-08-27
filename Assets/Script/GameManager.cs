using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool capture;
    public bool defeat;

    private void Awake()
    {
        if (instance != null && instance !=this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void CaptureEnemy()
    {
        capture = true;
    }
    public void EnemyyDefeated()
    {
        defeat = true;
       
    }
}
