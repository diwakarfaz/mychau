using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Utility
{
    public class COBAOContract
    {
        /// <summary>
        /// Nếu sai điều kiện thì trả về thông báo lỗi. Dùng để validate điều kiện vào (precondition).
        /// </summary>
        /// <param name="condition">Điều kiện vào</param>
        /// <param name="message">Thông báo lỗi trả về</param>
        public static string Requires(bool condition, string message)
        {
            if (condition)
            {
                return "";
            }
            else
            {
                return message + "\n";
            }
        }

        /// <summary>
        /// Nếu sai điều kiện thì trả về thông báo lỗi. Dùng để validate điều kiện ra (postcondition).
        /// </summary>
        /// <param name="condition">Điều kiện ra</param>
        /// <param name="message">Thông báo lỗi trả về</param>
        /// <returns></returns>
        public static string Ensures(bool condition, string message)
        {
            if (condition)
            {
                return "";
            }
            else
            {
                return message + "\n";
            }
        }
    }
}
