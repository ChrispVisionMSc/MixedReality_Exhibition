using Meta.XR.MRUtilityKit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMeshOnOff1 : MonoBehaviour
{
    public GameObject roomMesh;
    private bool hideMesh;

    public void EnableDisableMesh()
    {

        hideMesh = roomMesh.GetComponent<EffectMesh>().HideMesh;

        if (hideMesh == true)
        {
            hideMesh = false;
            Debug.LogWarning("Deactivating");
        }

        else if (hideMesh == false)
        {
            hideMesh = true;
            Debug.LogWarning("Enabling");
        }
            
    }        
}
