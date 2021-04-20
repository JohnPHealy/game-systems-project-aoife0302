using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu] //allows to creat as object using right click
public class FloatValue : ScriptableObject, ISerializationCallbackReceiver //means this script cannot be attached to anything in the scene, lives outside the scene, can be read through multiple scenes
{
    public float intialValue;

    [HideInInspector] //doesn't appear in the inspector
    public float RuntimeValue;

    public void OnAfterDeserialize() 
    {
        RuntimeValue = intialValue;
    }

    public void OnBeforeSerialize() { } //after unload
}
