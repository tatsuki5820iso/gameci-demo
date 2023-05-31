using System;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using Random = System.Random;

public class TestController : MonoBehaviour
{
    [SerializeField]
    TMP_Text _text = null;

    readonly PlayerFactory _factory = new();

    // Start is called before the first frame update
    void Start()
    {
        _text.text = $"Version: {Application.version}";
　
        var playerCount = new Random().Next(1, 10);

        for (var i = 0; i < playerCount; i++)
        {
            _factory.CreateNewPlayer();
        }

        print($"Created {playerCount} players!");
    }

    async UniTask DoFoo()
    {
        await UniTask.Delay(TimeSpan.FromSeconds(10));
    }
}