using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Sender.Properties;
using static System.Windows.Forms.ListView;
using Excel = Microsoft.Office.Interop.Excel;

namespace Sender {
    public partial class Form1 : Form {

        private MailAddress from;
        private Dictionary<String, MailType> dicMail;

        private String path = "";
        private List<String> mails;

        private static Color DGray = Color.FromArgb(26, 26, 29);

        private Excel.Application excel;
        private Workbook book;
        private Workbooks books;
        private _Worksheet sheet;
        private Range xlRange;

        public Form1() {
            InitializeComponent();
            dicMail = new Dictionary<string, MailType>() {
                { "mail", new MailType("smtp.mail.ru", 25, true) },
                { "gmail", new MailType("smtp.gmail.com", 587, true) }
            };

            try {
                tbLogin.Text = Settings.Default["login"].ToString();
                tbPass.Text = Settings.Default["pass"].ToString();
                tbName.Text = Settings.Default["name"].ToString();
                delay.Value = decimal.Parse(Settings.Default["delay"].ToString());
                repeat.Value = decimal.Parse(Settings.Default["repeat"].ToString());
                delayMsgAfter.Value = decimal.Parse(Settings.Default["delayMsgAfter"].ToString());
                delayMsg.Value = decimal.Parse(Settings.Default["delayMsg"].ToString());
            }
            catch { }

            mails = new List<string>();
        }

        int counterSend = 0;
        private async void send_Click(object sender, EventArgs e) {
            if (!isSend || btnSend.Text == "Отправка")
                return;

            from = new MailAddress(tbLogin.Text, tbName.Text);

            btnSend.ForeColor = Color.DimGray;
            btnSend.Text = "Отправка";

        Repeat:
            for (int i = 0; i < mails.Count; i++, await Task.Delay(int.Parse(delay.Value.ToString()) * 1000)) {
                if (checkDelay.Checked) {

                    if (counterSend == delayMsg.Value) {
                        await Task.Delay(int.Parse(delayMsgAfter.Value.ToString()) * 1000);
                        counterSend = 0;
                    }

                }
                    Send(new MailAddress(mails[i]), i);

                    counterSend++;
            }

            if (checkRepeat.Checked) {
                await Task.Delay(int.Parse(delay.Value.ToString()) * 1000);
                foreach (ListViewItem item in listBox1.Items)
                    item.ForeColor = Color.FromArgb(13, 202, 221);
                goto Repeat;
            }

            btnSend.Text = "Отправить";
            btnSend.ForeColor = Color.FromArgb(45, 184, 105);
        }

        private async void Send(MailAddress to, int index) {
            try {
                String key = from.Address.Split('@')[from.Address.Split('@').Length - 1].Split('.')[0];
                bool isError = false;
                using (MailMessage msg = new MailMessage(from, to))
                using (SmtpClient client = new SmtpClient()) {
                    msg.Subject = tbHead.Text;
                    msg.Body = tbMessage.Text;

                    client.Host = dicMail[key].Host;
                    client.Port = dicMail[key].Port;
                    client.EnableSsl = dicMail[key].EnableSsl;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(from.Address, tbPass.Text);
                    client.Timeout = 12000;

                    await Task.Run(() => {
                        try {
                            client.Send(msg);
                        }
                        catch {
                            isError = true;
                        }
                    });
                }
                lbErrorMail.Visible = isError;
                listBox1.Items[index].ForeColor = isError ? Color.FromArgb(195, 72, 118) : Color.FromArgb(45, 184, 105);
            }
            catch {
                lbErrorMail.Visible = true;
                listBox1.Items[index].ForeColor = Color.FromArgb(195, 72, 118);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Worksheets|*.xls;*.xlsx";
            dialog.FilterIndex = 2;
            listBox1.Items.Clear();
            mails.Clear();
            lbError.Text = "";
            if (dialog.ShowDialog() == DialogResult.OK) {
                lbError.Text = $"Загрузка данных..";
                path = dialog.FileName;
                label2.Text = path;

                ex();

                if (isFile)
                    label2.ForeColor = Color.FromArgb(13, 202, 221);
            }
            else
                lbError.Text = "";
        }

        bool isFile = false;
        public async void ex() {
            try {
                excel = new Excel.Application();
                books = excel.Workbooks;
                book = books.Open(path);
                sheet = book.Sheets[1];
                xlRange = sheet.UsedRange;

                int x = GetColumn();
                int y = GetRow();

                int startRow = 1;
                int startCol = 1;

                for (int i = startRow; i <= y; i++, await Task.Delay(1)) {
                    lbError.Text = $"Загрузка данных {i} / {y}";
                    for (int j = startCol; j <= x; j++, await Task.Delay(1)) {
                        if (xlRange.Cells[i, j] == null || xlRange.Cells[i, j].Value2 == null)
                            mails.Add(xlRange.Cells[i, j].Value2.ToString());
                        else {
                            listBox1.Items.Add(xlRange.Cells[i, j].Value2.ToString());
                            mails.Add(xlRange.Cells[i, j].Value2.ToString());
                        }


                        await Task.Delay(1);
                    }
                    await Task.Delay(1);
                }
            }
            catch {
                lbError.Text = "Ошибка";
                label2.Text = "Выберите Excel файл";
                label2.ForeColor = Color.DimGray;

                isFile = false;
                CloseExcelApp();
                mails.Clear();
                return;
            }
            CloseExcelApp();
            lbError.Text = "";
            isFile = true;
            CheckSend();
        }

        private int GetColumn() {
            return sheet.Cells.Find("*", System.Reflection.Missing.Value,
                                              System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                              XlSearchOrder.xlByColumns, XlSearchDirection.xlPrevious,
                                              false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Column;
        }

        private int GetRow() {
            return sheet.Cells.Find("*", System.Reflection.Missing.Value,
                                            System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                            XlSearchOrder.xlByRows, XlSearchDirection.xlPrevious,
                                            false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;
        }

        private void CloseExcelApp() {
            int hWnd = excel.Application.Hwnd;

            GetWindowThreadProcessId((IntPtr)hWnd, out uint processID);
            Process.GetProcessById((int)processID).Kill();

            book = null;
            excel = null;
            sheet = null;
        }

        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        bool isSend = false;
        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            CheckSend();
        }

        private void CheckSend() {
            isSend = isFile && tbLogin.Text.Length > 5 & tbPass.Text.Length > 4 && tbMessage.Text.Length > 0 && mails.Count > 0;
            if (isSend)
                btnSend.ForeColor = Color.FromArgb(45, 184, 105);
            else
                btnSend.ForeColor = Color.DimGray;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            tbPass.UseSystemPasswordChar = !checkPass.Checked;
            checkPass.ForeColor = !checkPass.Checked ? Color.FromArgb(195, 72, 118) : Color.FromArgb(45, 184, 105);
        }

        private void tbLogin_TextChanged(object sender, EventArgs e) {
            Settings.Default["login"] = tbLogin.Text;
            Settings.Default.Save();
        }

        private void tbPass_TextChanged(object sender, EventArgs e) {
            Settings.Default["pass"] = tbPass.Text;
            Settings.Default.Save();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            NumericUpDown numeric = sender as NumericUpDown;
            Settings.Default[$"{numeric.Name}"] = int.Parse(numeric.Value.ToString());
            Settings.Default.Save();
        }

        private void tbName_TextChanged(object sender, EventArgs e) {
            Settings.Default["name"] = tbName.Text;
            Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection items = listBox1.SelectedItems;

            for (int i = 0; i < items.Count; i++)
                listBox1.Items.Remove(items[i]);

            mails.Clear();

            foreach (ListViewItem item in listBox1.Items)
                mails.Add(item.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection x = listBox1.SelectedItems;
            btnDelete.Enabled = x != null;
        }


        bool click = false;
        int CoorX;
        int CoorY;
        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            click = true;
            CoorX = e.X;
            CoorY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            if (this.WindowState == FormWindowState.Maximized && click)
                this.WindowState = FormWindowState.Normal;
            if (click)
                this.SetDesktopLocation(MousePosition.X - CoorX, MousePosition.Y - CoorY);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) {
            click = false;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e) {
            bool delay = ((System.Windows.Forms.CheckBox)sender).Checked;

            delayMsg.Enabled = delay;
            delayMsgAfter.Enabled = delay;

            counterSend = 0;

            checkDelay.ForeColor = !checkDelay.Checked ? Color.FromArgb(195, 72, 118) : Color.FromArgb(45, 184, 105);
        }


        private void checkBox1_CheckedChanged_2(object sender, EventArgs e) {
            bool isRepeat = ((System.Windows.Forms.CheckBox)sender).Checked;

            repeat.Enabled = isRepeat;

            checkRepeat.ForeColor = !isRepeat ? Color.FromArgb(195, 72, 118) : Color.FromArgb(45, 184, 105);
        }


























        //RESIZE FORM-------------------------------------------------------------------------

        protected override void OnPaint(PaintEventArgs e) {
            e.Graphics.FillRectangle(new SolidBrush(DGray), Top);
            e.Graphics.FillRectangle(new SolidBrush(DGray), Left);
            e.Graphics.FillRectangle(new SolidBrush(DGray), Right);
            e.Graphics.FillRectangle(new SolidBrush(DGray), Bottom);
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 5; // you can rename this variable if you like

        System.Drawing.Rectangle Top { get { return new System.Drawing.Rectangle(0, 0, this.ClientSize.Width, _); } }
        System.Drawing.Rectangle Left { get { return new System.Drawing.Rectangle(0, 0, _, this.ClientSize.Height); } }
        System.Drawing.Rectangle Bottom { get { return new System.Drawing.Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        System.Drawing.Rectangle Right { get { return new System.Drawing.Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }
        System.Drawing.Rectangle TopLeft { get { return new System.Drawing.Rectangle(0, 0, _, _); } }
        System.Drawing.Rectangle TopRight { get { return new System.Drawing.Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        System.Drawing.Rectangle BottomLeft { get { return new System.Drawing.Rectangle(0, this.ClientSize.Height - _, _, _); } }
        System.Drawing.Rectangle BottomRight { get { return new System.Drawing.Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        protected override void WndProc(ref System.Windows.Forms.Message message) {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor))
                    message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor))
                    message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor))
                    message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor))
                    message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor))
                    message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor))
                    message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor))
                    message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor))
                    message.Result = (IntPtr)HTBOTTOM;
            }
        }
        //RESIZE FORM-------------------------------------------------------------------------

    }

    class MailType {
        public String Host;
        public int Port;
        public bool EnableSsl;

        public MailType(String Host, int Port, bool EnableSsl) {
            this.Host = Host;
            this.Port = Port;
            this.EnableSsl = EnableSsl;
        }
    }
}
