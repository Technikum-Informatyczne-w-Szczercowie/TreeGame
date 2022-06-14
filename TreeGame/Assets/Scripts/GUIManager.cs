using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    public static GUIManager instance;
    
    public Text scoreText;
    [SerializeField] Text info;

    private int _score = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text     = _score.ToString() + " POINTS";
    }

    public void AddPoint()
    {
        _score += 1;
        scoreText.text = _score.ToString() + " POINTS";
    }

    public void ShowInfo()
    {
        info.gameObject.SetActive(true);
    }
    
    public void HideInfo()
    {
        info.gameObject.SetActive(false);
    }
}
