using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Plant_Tests
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
     public void updateHp_test_2_hp_subtracts()
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
     public void updateHp_test_3_hp_die()
     {
         // ACT
         int initialHp = 3;
         int hpChange = -4;
        
         
         plant plant_a = new shooter();
         plant_a.setHp(initialHp);
         plant_a.updateHp_with_Substitude(hpChange);

         
         // ASSERT

         Assert.AreEqual((initialHp+hpChange), plant_a.getHp());
         
         Assert.IsTrue(plant_a.getDieFlag());

     }

     [Test]
     public void updateHp_test_4_hp_not_die()
     {
         // ACT
         int initialHp = 3;
         int hpChange = -2;
        
         
         plant plant_a = new shooter();
         plant_a.setHp(initialHp);
         plant_a.updateHp_with_Substitude(hpChange);

         
         // ASSERT

         Assert.AreEqual((initialHp+hpChange), plant_a.getHp());
         
         Assert.IsFalse(plant_a.getDieFlag());

     }
}
