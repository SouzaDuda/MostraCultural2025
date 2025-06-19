using UnityEngine;
using TMPro;

public class DebugNaTela : MonoBehaviour
{
    public TextMeshProUGUI textoNaTela;
    string log = "";

    void OnEnable()
    {
        Application.logMessageReceived += (msg, stack, tipo) =>
        {
            log = msg;
        };
    }

    void Update()
    {
        textoNaTela.text = log;
    }
}

