using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleLocalization;
public class LanguageManager : MonoBehaviour
{
    private void Awake()
    {
        LocalizationManager.Read();
        LocalizationManager.Language = "English";
    }

    public void ChangeLang()
    {
        if (LocalizationManager.Language=="English")
        {
            LocalizationManager.Language = "Greek";
        }
        else
        {
            LocalizationManager.Language = "English";
        }
    }

}
