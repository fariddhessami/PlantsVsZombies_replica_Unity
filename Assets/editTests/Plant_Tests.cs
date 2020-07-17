using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Plant_Tests : MonoBehaviour
{

    
    [Test]
    public void updateHp_test_1_hp_adds_up()
    {
        // ACT
        int initialHp = 3;
        int hpChange = 4;
        
        
        plant plant_a = new shooter();
        plant_a.setHp(initialHp);
        plant_a.updateHp(hpChange);
        
        // ASSERT

        Assert.AreEqual((initialHp+hpChange), plant_a.getHp());

    }
    
    [Test]
     public void updateHp_test_1_hp_subtracts()
     {
         // ACT
         int initialHp = 3;
         int hpChange = -2;
         
         
         plant plant_a = new shooter();
         plant_a.setHp(initialHp);
         plant_a.updateHp(hpChange);
         
         // ASSERT
 
         Assert.AreEqual((initialHp+hpChange), plant_a.getHp());
 
     }
     
     [Test]
     public void updateHp_test_1_hp_die()
     {
         // ACT
         int initialHp = 3;
         int hpChange = -2;
        
        
         GameObject gameObject1 = new GameObject();
         shooter plant_a = gameObject1.AddComponent<shooter>() as shooter;

         
         
         plant_a.updateHp(hpChange);
        
         // ASSERT

         // Assert.AreEqual((initialHp+hpChange), plant_a.getHp());

     }
}
