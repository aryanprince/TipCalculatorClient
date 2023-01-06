using ServiceReference1;
using static ServiceReference1.Service1Client;

namespace TipCalculatorClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            // Parse the text in the text boxes to get the input values
            double billAmount = double.Parse(txtBillAmt.Text);
            int numPeople = int.Parse(txtNoOfPeople.Text);
            double tipPercent = double.Parse(txtTipPercent.Text);

            // Create an instance of the proxy class
            Service1Client client = new Service1Client(EndpointConfiguration.BasicHttpsBinding_IService1);

            // Call the service operations
            double total = await client.CalculateTipAsync(billAmount, numPeople, tipPercent);
            double totalWithTip = await client.CalculateTotalWithTipAsync(billAmount, numPeople, tipPercent);
            double totalPerPerson = await client.CalculateTotalPerPersonAsync(billAmount, numPeople, tipPercent);

            // Display the results in the label
            lblResult.Text = $"Total: {total:F2}\nTotal with tip: {totalWithTip:F2}\nTotal per person: {totalPerPerson:F2}";
        }
    }
}