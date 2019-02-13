namespace Broadcast {
    public class StringUtil {
        /// <summary>
        /// 好像是第二种效率高一点，取str字符串中123左边的所有字符：第一种Between(str,"","123")，而第二种是Between(str,null,"123")。
        /// </summary>
        /// <param name="str"></param>
        /// <param name="strLeft"></param>
        /// <param name="strRight"></param>
        /// <returns></returns>
        public static string Between2(string str, string strLeft, string strRight) //取文本中间
        {
            if (str == null || str.Length == 0) return "";
            if (strLeft != null)
            {
                int indexLeft = str.IndexOf(strLeft);//左边字符串位置
                if (indexLeft < 0) return "";
                indexLeft = indexLeft + strLeft.Length;//左边字符串长度
                if (strRight != null)
                {
                    int indexRight = str.IndexOf(strRight, indexLeft);//右边字符串位置
                    if (indexRight < 0) return "";
                    return str.Substring(indexLeft, indexRight - indexLeft);//indexRight - indexLeft是取中间字符串长度
                }
                else return str.Substring(indexLeft, str.Length - indexLeft);//取字符串右边
            }
            else//取字符串左边
            {
                if (strRight == null) return "";
                int indexRight = str.IndexOf(strRight);
                if (indexRight <= 0) return "";
                else return str.Substring(0, indexRight);
            }
        }
    }
}