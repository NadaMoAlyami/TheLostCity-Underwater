using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrandFatherUIs : MonoBehaviour
{

    public GameObject Canvas;
    public GameObject QuestionMark;
    public GameObject GrandFatherPuzzle;
    public GameObject Player;
    //  public AudioClip Sounds;
    public AudioSource AudioSource;

    public int offset;


    private void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, Player.transform.position) < offset)
        {
            QuestionMark.SetActive(false);
            GrandFatherPuzzle.SetActive(true);
            GrandFatherTimer();

        }
        IEnumerator GrandFatherTimer()
        {
            yield return new WaitForSeconds(20f);
            GrandFatherPuzzle.SetActive(false);
            Canvas.SetActive(true);
            AudioSource.Play();


            /* SceneManager.LoadScene(SceneNumber);*/
        }

    }
}
