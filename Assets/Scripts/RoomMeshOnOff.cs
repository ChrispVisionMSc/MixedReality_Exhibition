using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMeshOnOff : MonoBehaviour
{
    public GameObject roomMesh;

    public void EnableDisableObject()
    {
        if (roomMesh.activeSelf == true)
        {
            roomMesh.SetActive(false);
            Debug.LogWarning("Deactivating");
        }

        else if (roomMesh.activeSelf == false)
        {
            roomMesh.SetActive(true);
            Debug.LogWarning("Enabling");
        }
            
    }        
}
