using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{
    public Camera cameraB,cameraA;

    public Material cameraMatB,cameraMatA;

    private void Start() 
    {
        if (cameraB.targetTexture != null) 
        {
            cameraB.targetTexture.Release();
        }

        if (cameraA.targetTexture != null) 
        {
            cameraA.targetTexture.Release();
        }
        cameraB.targetTexture = new RenderTexture(Screen.width,Screen.height, 24);
        cameraMatB.mainTexture = cameraB.targetTexture;

        cameraA.targetTexture = new RenderTexture(Screen.width,Screen.height, 24);
        cameraMatA.mainTexture = cameraA.targetTexture;
    }
}
