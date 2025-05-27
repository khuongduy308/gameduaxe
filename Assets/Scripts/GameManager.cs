using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float thoiGianChoPhepVeDich = 30f;
    public bool ketThucGame = false;
    public bool winGame = false;
    private static GameManager instance;
    public GameObject timeOverObject;
    public GameObject setGameOverObject;
    public GameObject winGameObject;
    [SerializeField]
    public float thoiGianHoiKhiQuaCheckPoint = 31f;

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
            if (thoiGianChoPhepVeDich <= 0)
            {
                setGameOverObject.SetActive(true);
                timeOverObject.SetActive(false);
                KetThucGame();
            }
            if (winGame)
            {
                timeOverObject.SetActive(false);
                winGameObject.SetActive(true);
            }
        }
    }
    public void KetThucGame()
    {
        ketThucGame = true;
    }
    public void quaCheckPoint()
    {
        if (!ketThucGame)
        {
            thoiGianChoPhepVeDich += thoiGianHoiKhiQuaCheckPoint;
        }
    }
    public void quaWinPoint()
    {
        if (!ketThucGame)
        {
            winGame = true;
        }
    }
}
