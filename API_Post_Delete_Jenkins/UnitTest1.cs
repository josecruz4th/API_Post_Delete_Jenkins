﻿using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace API_Post_Delete_Jenkins
{
    [TestClass]
    public class UnitTest1:Post_Delete_Classes
    {
        [Test]
        public void TestMethod1()
        {
            try
            {

                string strStringToVal = this.dataToPost("Jose", "12", "13");
                string strStringToDelete = this.dataToDelete(strStringToVal);
                Console.WriteLine("DELETE RESPONSE IS: " + strStringToDelete);

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

