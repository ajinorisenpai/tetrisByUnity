using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class testSceneScript : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI text;
    void Start()
    {
        button.onClick.AddListener(() => text.text = "button pushed!");
    }
    
}
