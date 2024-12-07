using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject lobby;
    [SerializeField] private GameObject select;
    [SerializeField] private GameObject tutorial;
    [SerializeField] private GameObject[] tutorialPages;

    [SerializeField] private int tutorialPage = 0;

    public void OnSelect()
    {
        lobby.SetActive(false);
        select.SetActive(true);
    }

    public void OnTutorial()
    {
        lobby.SetActive(false);
        tutorial.SetActive(true);
        OffAllTutorial();

        tutorialPages[0].SetActive(true);
    }

    public void NextTutorial()
    {
        tutorialPage++;
        if (tutorialPage >= tutorialPages.Length) { tutorialPage = 0; }
        OffAllTutorial();

        tutorialPages[tutorialPage].SetActive(true);
    }

    public void PrevTutorial()
    {
        tutorialPage--;
        if (tutorialPage <= -1) { tutorialPage = tutorialPages.Length - 1; }
        OffAllTutorial();

        tutorialPages[tutorialPage].SetActive(true);
    }

    private void OffAllTutorial()
    {
        for (int i = 0; i < tutorialPages.Length; i++)
        {
            tutorialPages[i].SetActive(false);
        }
    }

    public void OffTutorial()
    {
        tutorial.SetActive(false);
        lobby.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
