using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class setumeiScript : MonoBehaviour
{
    [SerializeField] GameObject Rule;
    [SerializeField] GameObject ExitButton;
    [SerializeField] GameObject Panel;
    // Start is called before the first frame update
    
    public void RuleClicked()
    {
        Rule.SetActive(false);
        ExitButton.SetActive(true);
        Panel.SetActive(true);
    }

    public void ExitClicked()
    {
        Rule.SetActive(true);
        ExitButton.SetActive(false);
        Panel.SetActive(false);
    }
    public void OnClick()
    {
        SceneManager.LoadScene("gamescene");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
