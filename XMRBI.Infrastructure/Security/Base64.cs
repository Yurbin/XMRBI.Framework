using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMRBI.Infrastructure
{
    public sealed class Base64
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        public static string Base64Code(string Message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(Message); 
            return Convert.ToBase64String(bytes);  
        }
          /// <summary>
          /// 解密
          /// </summary>
          /// <param name="Message"></param>
          /// <returns></returns>
        public static string Base64Decode(string Message)
        { 
            return  Encoding.UTF8.GetString(Convert.FromBase64String(Message));
        
        }
    }
}
