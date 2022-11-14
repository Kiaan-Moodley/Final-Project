using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeObjectScript : MonoBehaviour
{
    private SpriteRenderer rend;
    private Sprite one, three, two;
    
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        one = Resources.Load<Sprite>("character1");
        three = Resources.Load<Sprite>("CHARACTER4");
        two = Resources.Load<Sprite>("characte2");
        rend.sprite = one;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (rend.sprite == one)
                rend.sprite = three;
            else if (rend.sprite == three)
                rend.sprite = two;
            else if (rend.sprite == two)
                rend.sprite = one;
        }
    }

     /*
     int _currentCustomizationIndex;
     SpriteRenderer SpriteR;
     public List<Sprite> Sprites;
     public Customization Currentcustomization { get; private set; }

     private void Start()
     {
         SpriteR = child.GetComponent<SpriteRenderer>();
     }

     void LateUpdate()
     {
         SkinChoice();
         if (Input.GetKeyDown(KeyCode.C))
         {
             _currentCustomizationIndex++;
            Currentcustomization.NextSprite();
         }

     }

     void SkinChoice()
     {
         if (_currentCustomizationIndex > Sprites.Count - 1)
         {
             _currentCustomizationIndex = 0;
         }
         else if (_currentCustomizationIndex < 0)
         {
             _currentCustomizationIndex = Sprites.Count - 1;
         }
     }

     [System.Serializable]
     public class Customization
     {
         public List<Sprite> Renders;
         int index;

         public void NextSprite()
         {
             index++;
             if (index >= Renders.Count-1)
                 index = 0;

         }


     }*/
}
