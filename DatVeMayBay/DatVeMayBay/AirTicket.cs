using System;
using System.Windows.Forms;

namespace DatVeMayBay
{
    public partial class AirTicket : Form
    {
        public AirTicket()
        {
            InitializeComponent();
            for (int i = 0; i <= 20; i++)
            {
                Baggage.Items.Add(i.ToString());
            }

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txtTo.Text) && !string.IsNullOrWhiteSpace(txtFrom.Text)&&!string.IsNullOrWhiteSpace(txtNo.Text))
            {
                if (Baggage.SelectedItem == null)
                    Baggage.SelectedItem = Baggage.Items[0];
                var documentNo = new DocumentNo(lb8.Text, txtNo.Text);
                var dateTo = monthCalendarTo.SelectionRange.Start.ToShortDateString();
                var dateEnd = monthCalendarFrom.SelectionRange.Start.ToShortDateString();
                var travelDocument = TravelDocument();
                var x = new VeMayBay(txtFirstName.Text, txtLastName.Text, txtTo.Text, txtFrom.Text,travelDocument,txtNo.Text,dateTo,dateEnd,Baggage.SelectedItem.ToString());
                new Imformation(x).ShowDialog();
            }
            else
            {
                MessageBox.Show("not null ỏ white in text to,text from ,text no");
            }
            
        }

        private string TravelDocument()
        {
            if (Passport.Checked) return Passport.Text;
            IDCard.Checked = true;
            return IDCard.Text;
        }
        private void Check(CheckBox a, CheckBox b)
        {
            if (a.Checked) b.Checked = false;
            else b.Checked = true;
        }
        private void ChangeText()
        {
            if (Passport.Checked) lb8.Text = "Passport no: ";
            else lb8.Text = "IDCard no:";
        }

        private void Passport_CheckedChanged(object sender, EventArgs e)
        {
            Check(Passport, IDCard); ChangeText();
        }

        private void IDCard_CheckedChanged(object sender, EventArgs e)
        {
            Check(IDCard, Passport);
            ChangeText();
        }

        private void monthCalendarTo_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePickerTo.Value = monthCalendarTo.SelectionRange.Start;
        }

        private void monthCalendarFrom_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePickerFrom.Value = monthCalendarFrom.SelectionRange.Start;
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            monthCalendarTo.TodayDate = dateTimePickerTo.Value;
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            monthCalendarFrom.TodayDate = dateTimePickerFrom.Value;
        }

        private void Baggage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class DocumentNo
    {
        public DocumentNo(string name,string no)
        {
            this.Name = name;
            this.No = no;
        }

        public string Name { get; private set; }
        public string No { get; private set; }
    }

    public class VeMayBay
    {
        public VeMayBay(string firstName, string lastName, string to, string from, string travelDocument, DocumentNo documentNo, string dateTo, string dateEnd,string bagge)
        {
            this.FullName = firstName + " " + lastName;
            this.To = to;
            this.From = from;
            this.TravelDocument = travelDocument;
            this.DocumentNo = documentNo;
            this.DateTo = dateTo;
            this.DateEnd = dateEnd;
            this.Bagge = bagge;
        }

        public string Bagge { get; private set; }
        public string DateEnd { get; private set; }
        public string DateTo { get; private set; }
        public DocumentNo DocumentNo { get; private set; }
        public string From { get; private set; }
        public string FullName { get; private set; }
        public string To { get; private set; }
        public string TravelDocument { get; private set; }
    }
}
