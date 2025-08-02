using JamSeed.Foundation;
using UnityEngine;

public class Title : SceneSingleton<Title>
{
    [SerializeField] LiteButton startButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        startButton.AddOnClick(() =>
        {
            //SceneManager.LoadScene("Game");
        });
        startButton.AddOnEnter(() =>
        {
            startButton.transform.localScale = Vector3.one * 1.2f;
            Debug.Log("Start Button Hovered");
        });
        startButton.AddOnExit(() =>
        {
            startButton.transform.localScale = Vector3.one;
            Debug.Log("Start Button Exited");
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
