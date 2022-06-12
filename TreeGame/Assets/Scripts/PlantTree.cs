using UnityEngine;

public class PlantTree : MonoBehaviour
{
    public GameObject tree;
    public GameObject highlight;
    public bool grown = false;
    
    void OnTriggerStay(Collider other)
    {
        if (grown) return;
        
        ScoreManager.instance.ShowInfo();
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            tree.transform.localScale += new Vector3(0.7f, 0.7f, 0.7f);
            grown = true;
            Destroy(highlight);
            
            ScoreManager.instance.AddPoint();
            ScoreManager.instance.HideInfo();
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        ScoreManager.instance.HideInfo();
    }
}
