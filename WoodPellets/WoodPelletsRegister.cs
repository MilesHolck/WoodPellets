using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPellets
{
    public class WoodPelletsRegister
    {
        private static List<WoodPellet> woodPelletsList = new List<WoodPellet>();
        public static void AddWoodPellet(WoodPellet woodPellet)
        {
            woodPelletsList.Add(woodPellet);
        }
        public static void AddWoodPellet(string brand, string quality, string size, double price, string energy, string humidity, int stock, string info)
        {
            woodPelletsList.Add(new WoodPellet(brand, quality, size, price, energy, humidity, stock, info));
        }
        public static WoodPellet RemoveWoodPelletById(int id)
        {
            foreach (WoodPellet woodPellet in woodPelletsList)
            {
                if (woodPellet.Id == id)
                {
                    woodPelletsList.Remove(woodPellet);
                    return woodPellet;
                }
            }

            return null;
        }

        public static List<WoodPellet> GetWoodPellets()
        {
            return woodPelletsList; 
        }

        public static WoodPellet GetWoodPelletById(int id)
        {
            foreach (WoodPellet woodPellet in woodPelletsList)
            {
                if (woodPellet.Id == id)
                {
                    return woodPellet;
                }
            }
            return null;
        }
        
        public static List<WoodPellet> GetAllWoodPelletsByBrand(string brand)
        {
            List<WoodPellet> tempList = new List<WoodPellet>();

            foreach (WoodPellet woodPellet in woodPelletsList)
            {
                if (woodPellet.Brand == brand)
                {
                    tempList.Add(woodPellet);
                }
            } 

            return tempList;
        }

        public static void RemoveWoodPelletsByBrand(string brand)
        {
            List<WoodPellet> tempList = new List<WoodPellet>();

            foreach (WoodPellet woodPellet in woodPelletsList)
            {
                if (woodPellet.Brand != brand)
                {
                    tempList.Add(woodPellet);
                }
            }

            woodPelletsList = tempList;
        }
    }
}
