using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using RestSharp;

namespace Broadcast {
    public class OrderNetService {

        public string GetOrderJson(string url, string cookie) {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-type", "application/json; charset=utf-8");
            request.AddParameter("lDlk_ecc9_saltkey", "bz3ZPETN", ParameterType.Cookie);
            request.AddParameter("lDlk_ecc9_ulastactivity", "3932ZsQe%2BDd3IjMvfFtJIWYoeZoT884zdJjhzjX079qkMIlcI7c5", ParameterType.Cookie);
            request.AddParameter("lDlk_ecc9_auth", "f8c1DwdoSdsLlCc8eUwuPbW7y%2BZOyTS579qoLNWxPAgoIqATArtJrOqASFnApkzY3YGaLniA5RGozHgpC%2Fp0sIpieWc", ParameterType.Cookie);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public IList<Order> GetOrders(string keys, string text) {
            var keySplit = keys.Split('|');

            IList<Order> orders = new List<Order>();
            var matchCollection = Regex.Matches(text, "<tr><td>([\\s\\S]*?)</td></tr>");
            foreach (Match m in matchCollection) {
                string value = m.ToString();
                Order order = new Order();
                order.Url = StringUtil.Between2(value, "<tr><td><a href=\"", "\"");
                order.Title = StringUtil.Between2(value, order.Url + "\" target=\"_blank\">", "</a></td><td>");
                order.Title = order.Title.Replace("<span>", "");
                order.Title = order.Title.Replace("</span>", "");
                order.Amount = StringUtil.Between2(value, "<b>￥", "</b>");
                order.Time = StringUtil.Between2(value, "需要</td><td>", "</td><td>");
                if (keySplit.Count(item => order.Title.Contains(item)) == 0) {
                    orders.Add(order);
                }
            }
            return orders;
        }
    }
}