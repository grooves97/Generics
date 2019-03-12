using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSophisticatedLesson
{
    class Checker<T> where T: Employee,IManager,new()        //T это некий тип | where Это некое условие для установки цели действия 
    {


        public void MakeCheck(T entity)//Мы говорим о типе значит передаем тип T
        {
            //что-то делаем с T
            entity.DoManagerWork();

        }

        public T CreateEntity()
        {

            return new T();
        }

       /* public bool MakeCheck(object obj)
        {
            if (obj is IManager && obj is Employee)
            {
                //какая-та работа
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
