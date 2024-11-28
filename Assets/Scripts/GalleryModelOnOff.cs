using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryModelOnOff : MonoBehaviour
{
    private GameObject modelHolder;

    public void EnableDisableModel()
    {
        if (modelHolder != null)
        {
            if (modelHolder.activeSelf == true)
            {
                modelHolder.SetActive(false);
                Debug.LogWarning("Deactivating");
            }

            else if (modelHolder.activeSelf == false)
            {
                modelHolder.SetActive(true);
                Debug.LogWarning("Enabling");
            }
        }
        else
        {
            GameObject model = GameObject.Find("OTHER");
            modelHolder = model;

            if (modelHolder != null && modelHolder.activeSelf == true)
            {
                modelHolder.SetActive(false);
                Debug.LogWarning("Deactivating");
            }
        }
    }        
}
