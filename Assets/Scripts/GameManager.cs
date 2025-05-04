using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public float thoiGianChoPhepVeDich = 30f;
   public bool ketThucGame = false;
   private static GameManager instance;

   public static GameManager Instance
   {
    get
    {
        if (instance == null)
        {
            instance = FindAnyObjectByType<GameManager>();
            if (instance == null)
            {
                GameObject gameManagerGameObject = new GameObject("GameManager");
                instance = gameManagerGameObject.AddComponent<GameManager>();
            }
        }
        return instance;
    }
   }
    private void Update()
    {
        if (!ketThucGame)
        {
            thoiGianChoPhepVeDich -= Time.deltaTime;
            if(thoiGianChoPhepVeDich <= 0)
            {
                KetThucGame();
            }
        }
    }
    public void KetThucGame()
    {
        ketThucGame = true;
    }
}
