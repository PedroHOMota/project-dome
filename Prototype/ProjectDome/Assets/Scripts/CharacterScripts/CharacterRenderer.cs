﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Character Renderer contains a Character object and sets character Graphic Components (Hair, body and Clothes) to Character's animations.
/// </summary>
public class CharacterRenderer : MonoBehaviour {

    /// <summary>
    /// Character Scriptable Object
    /// </summary>
    public Character character;
    /// <summary>
    /// Player Reference.
    /// </summary>
    private Transform player;

    /// <summary>
    /// On start set Reference to GameObject. Find child Object "GFX" and set children values to Character's object attached values. -> On init().
    /// </summary>
    private void Start () {
        init();
    }

    /// <summary>
    /// Initializer
    /// </summary>
    private void init()
    {
        player = GetComponent<Transform>();
        player.GetComponent<Transform>().Find("GFX").GetComponent<Transform>().Find("Hair").GetComponent<Animator>().runtimeAnimatorController = character.char_headAnimator;
        player.GetComponent<Transform>().Find("GFX").GetComponent<Transform>().Find("Body").GetComponent<Animator>().runtimeAnimatorController = character.char_bodyAnimator;
        player.GetComponent<Transform>().Find("GFX").GetComponent<Transform>().Find("Clothes").GetComponent<Animator>().runtimeAnimatorController = character.char_clothesAnimator;

    }

    /// <summary>
    /// Update Unnotified Player Changes.
    /// </summary>
    private void FixedUpdate()
    {
        init();
    }


}
