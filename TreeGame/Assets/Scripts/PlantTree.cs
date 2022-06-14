using System;
using UnityEngine;

public class PlantTree : MonoBehaviour
{
    public GameObject tree;           
    public GameObject highlight;       
    public bool grown = false;

    void OnTriggerStay(Collider other)
    {
        if (grown) return;
        
        GUIManager.instance.ShowInfo();             

        if (Input.GetKeyDown(KeyCode.F))
        {
            var transformLocalScale = tree.transform.localScale;
            
            transformLocalScale.x = transformLocalScale.x * 8f;
            transformLocalScale.y = transformLocalScale.y * 8f;
            transformLocalScale.z = transformLocalScale.z * 8f;
            
            tree.transform.localScale = transformLocalScale;         
            
            grown = true;
            Destroy(highlight);
            
            GUIManager.instance.AddPoint();         
            GUIManager.instance.HideInfo();         
        }
    }
    
    void OnTriggerExit(Collider other)            
    {
        GUIManager.instance.HideInfo();            
    }
}
