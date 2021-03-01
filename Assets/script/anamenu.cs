using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anamenu : MonoBehaviour
{

    public GameObject info;
    public GameObject policy;

    bool infomenu = false;

    private int policykabul = 0;

    public void basla_btn()
    {
        SceneManager.LoadScene("Scenes/recbird");
        Time.timeScale = 1.0f;
    }

    public void info_btn()
    {
        infomenu = !infomenu;

        if (infomenu == true)
        {
            info.SetActive(true);

        }

        else
        {
            info.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        policykabul = PlayerPrefs.GetInt("policyolay");
        if (policykabul == 0)
        {
            policy.SetActive(true);
        }
        else
        {
            policy.SetActive(false);
        }
       
    }

    public void onAccept()
    {
        Debug.LogWarning("Policy Accepted");
        policy.SetActive(false);
        policykabul = 1;
        PlayerPrefs.SetInt("policyolay", policykabul);
    }

    public void termofservice()
    {
        Application.OpenURL("https://unity3d.com/legal/terms-of-service");
    }

    public void privacypolicy()
    {
        Application.OpenURL("https://unity3d.com/legal/privacy-policy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
