using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vrrrrr : MonoBehaviour
{
    public GameObject questionMark;
    public Canvas Canvas;
    public GameObject Player;
    public int offset;
    private Animator anim;

    private void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, Player.transform.position) < offset)
        {
            questionMark.gameObject.SetActive(false);
            Canvas.gameObject.SetActive(true);
            anim.SetTrigger("talks");
        }
        else
        {
            questionMark.gameObject.SetActive(true);
            Canvas.gameObject.SetActive(false);
            anim.SetTrigger("away");
        }
    }
    /* public void OnTriggerEnter(Collider other)
     {
         /* TrigExist.instance.CurrentCollider= GetComponent<VRUIOperations>();
          OnEnter.Invoke();*//*
         gm.gameObject.SetActive(false);
     }*/
}
