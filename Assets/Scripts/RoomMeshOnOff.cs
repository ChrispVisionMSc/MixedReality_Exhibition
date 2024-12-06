using Meta.XR.MRUtilityKit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMeshOnOff : MonoBehaviour
{
    public GameObject roomMesh;

    public void EnableDisableMesh()
    {

        if (roomMesh.GetComponent<EffectMesh>().HideMesh == true)
        {
            roomMesh.GetComponent<EffectMesh>().HideMesh = false;
            Debug.LogWarning("Deactivating");
        }

        else if (roomMesh.GetComponent<EffectMesh>().HideMesh == false)
        {
            roomMesh.GetComponent<EffectMesh>().HideMesh = true;
            Debug.LogWarning("Enabling");
        }
            
    }        
}
