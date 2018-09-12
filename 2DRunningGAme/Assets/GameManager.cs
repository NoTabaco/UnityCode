using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject winPanelObj, losePanelObj;

	public void Win()
    {
        winPanelObj.SetActive(true);
        Time.timeScale = 0;
  //      Debug.Log("Win !");
    }

    public void Lose()
    {
        losePanelObj.SetActive(true);
        Time.timeScale = 0;
        //      Debug.Log("Lose !");
    }

    // 내가 Play한 것을 보여주는 게 아닌 Scene을 전환하여 다시 Play하도록 하게 해줌
    public void Replay()
    {
        SceneManager.LoadScene("Play");
    }
}
