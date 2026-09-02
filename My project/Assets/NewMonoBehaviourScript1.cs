using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{ 
    public  TextMeshProUGUI textBox;

    public void ButtonClickMethod()
    {
        textBox.text = "I have changed";
    }
}
