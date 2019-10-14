 using Microsoft.VisualStudio.TestTools.UnitTesting;
 using System.Collections.Generic;
 using ToDoList.Models;
 using System;
 using MySql.Data.MySqlClient;

 namespace ToDoList.Tests
{
    [TestClass]
    public class ItemTest : IDisposable
    {

        public void Dispose()
        {
            Item.ClearAll();
        }

        public ItemTest()
        {
        DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=to_do_list_test;";
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyListFromDatabase_ItemList()
        {
        //Arrange
        List<Item> newList = new List<Item> { };

        //Act
        List<Item> result = Item.GetAll();

        //Assert
        CollectionAssert.AreEqual(newList, result);
        }

        //     [TestMethod]
        // public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
        // {
        //     //Arrange
        //     string description = "Walk the dog.";
        //     Item newItem = new Item(description);

        //     //Act
        //     int result = newItem.Id;

        //     //Assert
        //     Assert.AreEqual(1, result);
        // }

        //     [TestMethod]
        // public void Find_ReturnsCorrectItem_Item()
        // {
        //     //Arrange
        //     string description01 = "Walk the dog";
        //     string description02 = "Wash the dishes";
        //     Item newItem1 = new Item(description01);
        //     Item newItem2 = new Item(description02);

        //     //Act
        //     Item result = Item.Find(2);

        //     //Assert
        //     Assert.AreEqual(newItem2, result);
        // }

            [TestMethod]
        public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Item()
        {
        // Arrange, Act
        Item firstItem = new Item("Mow the lawn");
        Item secondItem = new Item("Mow the lawn");

        // Assert
        Assert.AreEqual(firstItem, secondItem);
        }

    }
}
