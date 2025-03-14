using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class Example : MonoBehaviour
{
    public TMP_Text caixaTexto;
    public Button OK;
    public TMP_InputField EnviarTexto;
    public TMP_InputField EnviarTexto2;

    private void Start()
    {
        caixaTexto.text = "O rato roeu a roupa do rei de roma";
    }

    public void TrocaMensagem() 
    {
        int num1 = int.Parse(EnviarTexto.text);
        int num2 = int.Parse(EnviarTexto2.text);

        caixaTexto.text = "OLA MUNDO" + (num1 + num2).ToString();
    }
}

