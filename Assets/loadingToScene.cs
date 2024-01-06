using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingToScene : MonoBehaviour
{

    private GameObject gameObject;
    public float secondsAmount = 7.0f;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(ShowAndHideGameObject());
    }

    private IEnumerator ShowAndHideGameObject()
    {

        yield return new WaitForSeconds(secondsAmount);
        SceneManager.LoadScene(5);

    }
}
