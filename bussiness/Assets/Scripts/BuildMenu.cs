using UnityEngine.UI;
using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    public Button buttonMenu;
    public Button buttonFactory;
    public Button buttonBaobab;
    public Button buttonBack;

    public void OpenMenu()
    {
        buttonMenu.gameObject.SetActive(false);
        buttonFactory.gameObject.SetActive(true);
        buttonBaobab.gameObject.SetActive(true);    
        buttonBack.gameObject.SetActive(true);
    }

    public void BackToMenu()
    {
        buttonMenu.gameObject.SetActive(true);
        buttonFactory.gameObject.SetActive(false);
        buttonBaobab.gameObject.SetActive(false);
        buttonBack.gameObject.SetActive(false);
    }
}
