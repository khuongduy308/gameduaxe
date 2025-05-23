using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void Update()
    {
        hienThiThoiGianGame();
    }
    public void hienThiThoiGianGame(){
        timeText.SetText(Mathf.FloorToInt(GameManager.Instance.thoiGianChoPhepVeDich).ToString());
    }
    public void playAgain(){
        SceneManager.LoadScene("Game");
    }
    public void backMenu(){
        SceneManager.LoadScene("Menu");
    }
}
