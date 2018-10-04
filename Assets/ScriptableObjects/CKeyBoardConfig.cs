using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Key Config", menuName = "ScriptableObjects/Create Key Config")]
public class CKeyBoardConfig : ScriptableObject
{
    public KeyCode jump = KeyCode.Space;
    public KeyCode moveLeft = KeyCode.LeftArrow;
    public KeyCode moveRight = KeyCode.RightArrow;
    public KeyCode sceneChange = KeyCode.Z;
}
