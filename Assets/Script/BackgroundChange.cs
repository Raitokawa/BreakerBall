using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundChange : MonoBehaviour
{
    public int level;
    public Sprite[] backgroundImage;
    public SpriteRenderer backgroundManager;
    Player player;

    private void Start()
    {
        backgroundManager = GetComponent<SpriteRenderer>();
        player = Player.instance;
    }

    private void Update()
    {
        backgroundManager.sprite=backgroundImage[player.level];
    }
}
