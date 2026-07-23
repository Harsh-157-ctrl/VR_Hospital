using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PatientVerification : MonoBehaviour
{
    public Button[] questionButtons;
    public TMP_Text responseText;

    public GameObject verificationCanvas;

    [TextArea]
    public string[] responses;

    void Start()
    {
        responseText.text = "";

        for (int i = 0; i < questionButtons.Length; i++)
        {
            int index = i;

            questionButtons[i].onClick.AddListener(() =>
            {
                ShowResponse(index);
            });
        }
    }

    void ShowResponse(int index)
    {
        StopAllCoroutines();
        StartCoroutine(TypeResponse(responses[index]));
    }

    IEnumerator TypeResponse(string response)
    {
        responseText.text = "";

        foreach (char letter in response)
        {
            responseText.text += letter;
            yield return new WaitForSeconds(0.03f);
        }
    }

    public void CloseUI()
    {
        StopAllCoroutines();
        responseText.text = "";
        verificationCanvas.SetActive(false);
    }
}