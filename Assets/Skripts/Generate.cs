using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class Human
{
    public List<BodyPartIndicator> points;

    public void GenerateHuman(List<BodyParts> bodyparts)
    {
        foreach (var item in points)
        {
            var sr = item.GetComponent<SpriteRenderer>();
            var list = bodyparts.FindAll(x => x.kind == item.kind);
            if (list.Count != 0)
            {
                var i = Random.Range(0, list.Count);
                sr.sprite = list[i].sprite;
                sr.transform.localScale = list[i].scale;
                sr.transform.localPosition = item.startPos + (Vector2)list[i].offset;
            }
        }
        Legs(bodyparts);
        Eye(bodyparts);
        Eyebrow(bodyparts);
    }

    public void Legs(List<BodyParts> bodyparts)
    {
        var rl = points.Find(x => x.kind == BodyParts.Kind.legRight);
        var ll = points.Find(x => x.kind == BodyParts.Kind.legLeft);
        rl.GetComponent<SpriteRenderer>().sprite = ll.GetComponent<SpriteRenderer>().sprite;
        rl.transform.localPosition = rl.startPos + (Vector2)bodyparts.Find(x => x.sprite == ll.GetComponent<SpriteRenderer>().sprite).offset;
    }

    public void Eye(List<BodyParts> bodyparts)
    {
        var re = points.Find(x => x.kind == BodyParts.Kind.eyeRight);
        var le = points.Find(x => x.kind == BodyParts.Kind.eyeLeft);
        re.GetComponent<SpriteRenderer>().sprite = le.GetComponent<SpriteRenderer>().sprite;
        re.transform.localPosition = re.startPos + (Vector2)bodyparts.Find(x => x.sprite == le.GetComponent<SpriteRenderer>().sprite).offset;
    }

    public void Eyebrow(List<BodyParts> bodyparts)
    {
        var reb = points.Find(x => x.kind == BodyParts.Kind.eyeRight);
        var leb = points.Find(x => x.kind == BodyParts.Kind.eyeLeft);
        reb.GetComponent<SpriteRenderer>().sprite = leb.GetComponent<SpriteRenderer>().sprite;
        reb.transform.localPosition = reb.startPos + (Vector2)bodyparts.Find(x => x.sprite == leb.GetComponent<SpriteRenderer>().sprite).offset;
    }
}

public class Generate : MonoBehaviour
{
    public List<BodyParts> bodyparts;
    public Human human;

    public void _Generate()
    {
        human.GenerateHuman(bodyparts);
    }
}
