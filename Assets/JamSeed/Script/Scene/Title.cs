using JamSeed.Foundation;
using UnityEngine;
using DG.Tweening; // DOTween

public class Title : SceneSingleton<Title>
{
    [SerializeField] LiteButton startButton;

    // アニメーション時間
    [SerializeField] float hoverScaleDuration = 0.2f;
    [SerializeField] float normalScaleDuration = 0.2f;

    // スケール値
    [SerializeField] float hoverScale = 1.2f;

    void Start()
    {
        startButton.AddOnClick(() =>
        {
            //SceneManager.LoadScene("Game");
        });

        startButton.AddOnEnter(() =>
        {
            startButton.transform
                .DOScale(Vector3.one * hoverScale, hoverScaleDuration)
                .SetEase(Ease.OutBack);
            Debug.Log("Start Button Hovered");
        });

        startButton.AddOnExit(() =>
        {
            startButton.transform
                .DOScale(Vector3.one, normalScaleDuration)
                .SetEase(Ease.OutBack);
            Debug.Log("Start Button Exited");
        });
    }
}
