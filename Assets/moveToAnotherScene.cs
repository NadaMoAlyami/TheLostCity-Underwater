using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class moveToAnotherScene : MonoBehaviour
{
    public GameObject Player;
    public int offset;


    private void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, Player.transform.position) < offset)
        {

           
            SceneManager.LoadScene(2);
            Debug.Log("worrrrrk");
            
        }
       
    }
    }


