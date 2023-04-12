using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxesSynchronization
{
    public class ViewModel
    {
        public List<Model> Data1 { get; set; }
        public List<Model> Data2 { get; set; }
        public List<Model> Data3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ViewModel()
        {
            Data1 = new List<Model>();

            for (int i = 0; i < 4; i++)
            {
                Data1.Add(new Model("1", 7.8));
                Data1.Add(new Model("2", 4.8));
                Data1.Add(new Model("3", 4.9));
                Data1.Add(new Model("4", 7.4));
                Data1.Add(new Model("5", 6.9));
                Data1.Add(new Model("6", 8.3));
                Data1.Add(new Model("7", 7.1));
                Data1.Add(new Model("8", 4.5));
                Data1.Add(new Model("9", 6.7));
                Data1.Add(new Model("10", 12.1));
            }

            Data2 = new List<Model>();

            for (int i = 0; i < 4; i++)
            {
                Data2.Add(new Model("1", 4.8));
                Data2.Add(new Model("2", 4.8));
                Data2.Add(new Model("3", 4.9));
                Data2.Add(new Model("4", 9.1));
                Data2.Add(new Model("5", 4.2));
                Data2.Add(new Model("6", 9.1));
                Data2.Add(new Model("7", 7.1));
                Data2.Add(new Model("8", 4.5));
                Data2.Add(new Model("9", 7.7));
                Data2.Add(new Model("10", 8.1));
            }

            Data3 = new List<Model>();

            for (int i = 0; i < 4; i++)
            {
                Data3.Add(new Model("1", 7.8));
                Data3.Add(new Model("2", 4.8));
                Data3.Add(new Model("3", 4.9));
                Data3.Add(new Model("4", 7.4));
                Data3.Add(new Model("5", 6.9));
                Data3.Add(new Model("6", 8.3));
                Data3.Add(new Model("7", 7.1));
                Data3.Add(new Model("8", 4.5));
                Data3.Add(new Model("9", 6.7));
                Data3.Add(new Model("10", 11.1));
            }
        }
    }
}
