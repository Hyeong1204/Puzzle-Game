using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntercatObject : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    [Header("반드시 0번은 상호작용전 이미지 1번은 상호작용 후 이미지")]
    [SerializeField]
    Sprite[] sprite = new Sprite[2];

    public bool onoff;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        Close();
    }

    private void Update()
    {
        if (onoff)
        {
            spriteRenderer.sprite = sprite[1];
        }
        else
        {
            spriteRenderer.sprite = sprite[0];
        }
    }

    void Close()
    {
        spriteRenderer.sprite = sprite[0];
    }

    void Open()
    {

    }
}
