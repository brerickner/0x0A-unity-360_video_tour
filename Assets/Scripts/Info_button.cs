using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Info_button : MonoBehaviour
{
    public GameObject Textfield;

    public void SetText()
    {
        if (Textfield.activeSelf == false)
        {
            Textfield.SetActive(true);
        }
        else {
            Textfield.SetActive(false);
        }

    }
}
