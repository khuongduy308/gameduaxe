using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public float thoiGianChoPhepVeDich = 30f;
   public bool ketThucGame = false;
   private static GameManager instance;
   public GameObject timeOverObject;
   public GameObject setGameOverObject;

   public static GameManager Instance
   {
    get
    {
        if (instance == null)
        {
            instance = FindObjectOfType<GameManager>();
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
            // Debug.Log(thoiGianChoPhepVeDich);
            if(thoiGianChoPhepVeDich <= 0)
            {
                setGameOverObject.SetActive(true);
                timeOverObject.SetActive(false);
                KetThucGame();
            }
        }
    }
    public void KetThucGame()
    {
        ketThucGame = true;
    }
}
