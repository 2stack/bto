using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Broadcast
{
    public partial class Form1 : Form {
        public string TestHtml { get; set; } = Properties.Resources.TestHtml;
        public OrderNetService OrderNetService { get; set; } = new OrderNetService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            timer1.Interval = 1000 * 60;
            timer1.Start();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var orderJson = OrderNetService.GetOrderJson(tbUrl.Text, tbCookie.Text);
            tbLog.AppendText(orderJson + "\r\n");
            tbLog.ScrollToCaret();
            if (orderJson == "") return;
            var deserializeObject = JsonConvert.DeserializeObject<OrderJson>(orderJson);
            if (deserializeObject.Data == null) {
                return;
            }
            var orders = OrderNetService.GetOrders(tbKey.Text.Trim(), deserializeObject.Data);
            foreach (var order in orders)
            {
                listBox1.Items.Add($"{order.Amount}元 * {order.Time} * {order.Title} * https://bbs.125.la/{order.Url}");
            }
        }

        private void lkCleanList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void lkCleanLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            tbLog.Text = "";
        }

        private void listBox1_DoubleClick(object sender, EventArgs e) {
            var text = ((System.Windows.Forms.ListBox)sender).Text;
            var strings = text.Split(" * ".ToCharArray());
            System.Diagnostics.Process.Start(strings[10]);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            var orderJson = OrderNetService.GetOrderJson(tbUrl.Text, tbCookie.Text);
            tbLog.AppendText(orderJson + "\r\n");
            tbLog.ScrollToCaret();
            if (orderJson == "") return;
            var deserializeObject = JsonConvert.DeserializeObject<OrderJson>(orderJson);
            if (deserializeObject.Data == null)
            {
                return;
            }
            var orders = OrderNetService.GetOrders(tbKey.Text.Trim(), deserializeObject.Data);
            foreach (var order in orders)
            {
                listBox1.Items.Add($"{order.Amount}元 * {order.Time} * {order.Title} * https://bbs.125.la/{order.Url}");
            }
        }
    }
}
