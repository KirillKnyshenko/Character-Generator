using UnityEngine;

[System.Serializable]
public class BodyParts
{
    public string name;
    public Sprite sprite;
    public Vector3 offset;
    public Vector3 scale = Vector3.one;
    public Kind kind;
    public enum Kind{handRight, handLeft, legRight, legLeft, eyeLeft, eyebrowLeft, mounth, mustache, life, head, hat, clothes, pants, eyeRight, eyebrowRight};
}