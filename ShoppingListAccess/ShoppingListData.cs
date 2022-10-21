using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ShoppingListObjects;

namespace ShoppingListAccess
{
    public class ShoppingListData
    {
        public static List<ShoppingLists> GetShoppingLists()
        {
            List<ShoppingLists> shoppingLists = new List<ShoppingLists>();
            char[] seperator = { ',' };
            try
            {
                StreamReader fileReader = new StreamReader(AppData.ListDataPath + "\\" + AppData.ShoppingListFileName);
                while(fileReader.EndOfStream == false)
                {
                    string eachLine = fileReader.ReadLine();
                    string[] partsOfFile;
                    if (eachLine.Length > 16)
                    {
                        partsOfFile = eachLine.Split(seperator);
                        if (partsOfFile.Count() == 4)
                        {
                            ShoppingLists newShoppingLists = new ShoppingLists();
                            newShoppingLists.ListName = partsOfFile[0];
                            newShoppingLists.Author = partsOfFile[1];
                            newShoppingLists.FileName = partsOfFile[2];
                            newShoppingLists.DatedCreated = partsOfFile[3];
                            shoppingLists.Add(newShoppingLists);
                        }
                    }
                }
                fileReader.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return shoppingLists;
        }
        
        public static ListItems GetShoppingListItems(ShoppingLists shoppingLists)
        {
            ListItems listItems = new ListItems();
            
            try
            {
                StreamReader readFile = new StreamReader(AppData.ListDataPath + "\\" + shoppingLists.FileName);
                listItems.Listname = readFile.ReadLine();
                listItems.ItemName = readFile.ReadToEnd();
                readFile.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return listItems;
        }

        public static bool AddNewList(ListItems listItems, ShoppingLists shoppingLists)
        {
            try
            {
                StreamWriter writeFile = new StreamWriter(AppData.ListDataPath + "\\" + shoppingLists.FileName);
                writeFile.WriteLine(listItems.Listname);
                writeFile.Write(listItems.ItemName);
                writeFile.Close();
                StreamWriter secondWriteFile = new StreamWriter(AppData.ListDataPath + "\\" + AppData.ShoppingListFileName, true);
                secondWriteFile.WriteLine(shoppingLists.ListName + ","
                                          + shoppingLists.Author + ","
                                          + shoppingLists.FileName + ","
                                          + shoppingLists.DatedCreated);
                secondWriteFile.Close();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        

        public static bool EditList(int listIndex, ListItems listItems, List<ShoppingLists> shoppingLists)
        {
            try
            {
                StreamWriter writeFile = new StreamWriter(AppData.ListDataPath + "\\" + shoppingLists[listIndex].FileName);
                writeFile.WriteLine(listItems.Listname);
                writeFile.WriteLine(listItems.ItemName);
                writeFile.Close();
                StreamWriter writeFile2 = new StreamWriter(AppData.ListDataPath + "\\" + AppData.ShoppingListFileName);
                foreach (ShoppingLists shoppingLists1 in shoppingLists)
                {
                    writeFile2.WriteLine(shoppingLists1.ListName + ","
                                          + shoppingLists1.Author + ","
                                          + shoppingLists1.FileName + ","
                                          + shoppingLists1.DatedCreated);
                }
                writeFile2.Close();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }

}
