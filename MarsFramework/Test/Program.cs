﻿using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            [System.Obsolete]
            public void EnterSkillTest()
            {
                ShareSkill skill = new ShareSkill();
                skill.EnterShareSkill();

            }
            [Test]
            [System.Obsolete]
            public void EditSkillTest()
            {
                ManageListings skill = new ManageListings();
                skill.EditManageListings();

            }
            
            [Test]
            [System.Obsolete]
            public void DeleteSkillTest()
            {
                ManageListings mld = new ManageListings();
                mld.DeleteShareSkill("Yes");


            }



        }
    }
}