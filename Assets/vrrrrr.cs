using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrrrrr : MonoBehaviour
{
    public GameObject gm;
    public GameObject Player;
    public int offset;

    private void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, Player.transform.position) < offset)
        {
            gm.gameObject.SetActive(false);
        }
        else
        {
            gm.gameObject.SetActive(true);
        }
    }
    /* public void OnTriggerEnter(Collider other)
     {
         /* TrigExist.instance.CurrentCollider= GetComponent<VRUIOperations>();
          OnEnter.Invoke();*//*
         gm.gameObject.SetActive(false);
     }*/
}
