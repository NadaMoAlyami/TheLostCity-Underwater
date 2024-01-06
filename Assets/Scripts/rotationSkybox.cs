using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationSkybox : MonoBehaviour
{
    public float SkyboxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("Rotation" , Time.time *  SkyboxSpeed);
    }
}
