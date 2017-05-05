using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KFC.Builder
{
    public class XMLUtil
    {
        public static object GetClassName()
        {
            object obj = null;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("MealClass.xml");    //加载Xml文件  
                XmlElement rootElem = doc.DocumentElement;   //获取根节点  
                XmlNodeList personNodes = rootElem.GetElementsByTagName("config"); //获取config子节点集合  
                foreach (XmlNode node in personNodes)  //默认只有一个结点的集合
                {
                    XmlNodeList subAgeNodes = ((XmlElement)node).GetElementsByTagName("className");  //获取className子集XmlElement集合  
                    if (subAgeNodes.Count == 1)
                    {
                        string className = subAgeNodes[0].InnerText; //得到类名
                        string nameSpace = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace; //得到当前命名空间
                        Assembly assembly = Assembly.GetExecutingAssembly();   //得到程序集
                        obj = assembly.CreateInstance(nameSpace + "." + className);//反射实例化对象
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("异常：" + ex.Message);
            }
            return obj;
        }
    }
}
