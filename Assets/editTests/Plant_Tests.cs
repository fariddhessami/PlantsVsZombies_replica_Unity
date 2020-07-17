using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Plant_Tests : MonoBehaviour
{


    // [Test]
    // public void METHOD()
    // {
    //     //    ACT
    //     
    //     plant plant_a = new shooter();
    //     Assert.AreEqual(1, plant_a.getHp());
    //     
    //     plant_a.updateHp(12);
    //     
    //     //    ASSERT
    //
    //     Assert.AreEqual(1, 1);
    //     Assert.AreEqual(1, 2);
    // }
    
    [Test]
    public void updateHp_test()
    {
        //    ACT
        plant plant_a = new shooter();
        Assert.AreEqual(1, plant_a.getHp());
        
        plant_a.updateHp(12);
        
        //    ASSERT

        Assert.AreEqual(1, 1);
        Assert.AreEqual(1, 2);
    }
}
