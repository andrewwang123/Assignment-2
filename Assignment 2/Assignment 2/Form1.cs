using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_2
{
    public partial class Form1 : Form
    {

        protected int TextBoxCount { get; set; }

        private StreamWriter goetzWriter;
        private StreamReader goetzReader;
        List<Panel> listPanel = new List<Panel>();

        public enum TextBoxIndices { ID, Company, TickerSymbol, MarketPrice, Shares, OrderType }


        
        public Form1()
        {
            InitializeComponent();
        }


        public class Record
        {
            public int ID { get; set; }
            public string Company { get; set; }
            public string TickerSymbol { get; set; }
            public double MarketPrice { get; set; }
            public int Shares { get; set; }
            public string OrderType { get; set; }

            //default values
            public Record() : this(0, string.Empty, string.Empty, 0.0 , 0, string.Empty ) { }

            public Record(int productID, string productCompany, string productTickerSymbol, double productMarketPrice,
                          int productShares, string productOrderType)
            {
                ID = productID;
                Company = productCompany;
                TickerSymbol = productTickerSymbol;
                MarketPrice = productMarketPrice;
                Shares = productShares;
                OrderType = productOrderType;
            }
        }


        public void ClearTextBoxes()
        {
            foreach (Control inControl in Controls)
            {
                (inControl as TextBox)?.Clear();
            }
        }


        public void SetTextBoxValues(string[] values)
        {
            
            productID.Text = values[(int)TextBoxIndices.ID];
            productCompany.Text = values[(int)TextBoxIndices.Company];
            productTickerSymbol.Text = values[(int)TextBoxIndices.TickerSymbol];
            productMarketPrice.Text = values[(int)TextBoxIndices.MarketPrice];
            productShares.Text = values[(int)TextBoxIndices.Shares];
            productOrderType.Text = values[(int)TextBoxIndices.OrderType];

            productID2.Text = values[(int)TextBoxIndices.ID];
            productCompany2.Text = values[(int)TextBoxIndices.Company];
            productTickerSymbol2.Text = values[(int)TextBoxIndices.TickerSymbol];
            productMarketPrice2.Text = values[(int)TextBoxIndices.MarketPrice];
            productShares2.Text = values[(int)TextBoxIndices.Shares];
            productOrderType2.Text = values[(int)TextBoxIndices.OrderType];

        }

        public void OpenTextBoxValues(string[] values)
        {
            productID.Text = values[(int)TextBoxIndices.ID];
            productCompany.Text = values[(int)TextBoxIndices.Company];
            productTickerSymbol.Text = values[(int)TextBoxIndices.TickerSymbol];
            productMarketPrice.Text = values[(int)TextBoxIndices.MarketPrice];
            productShares.Text = values[(int)TextBoxIndices.Shares];
            productOrderType.Text = values[(int)TextBoxIndices.OrderType];

            productID2.Text = values[(int)TextBoxIndices.ID];
            productCompany2.Text = values[(int)TextBoxIndices.Company];
            productTickerSymbol2.Text = values[(int)TextBoxIndices.TickerSymbol];
            productMarketPrice2.Text = values[(int)TextBoxIndices.MarketPrice];
            productShares2.Text = values[(int)TextBoxIndices.Shares];
            productOrderType2.Text = values[(int)TextBoxIndices.OrderType];

        }

        public string[] GetTextBoxValues()
        {
            return new string[]
            {
                productID.Text,
                productCompany.Text,
                productTickerSymbol.Text,
                productMarketPrice.Text,
                productShares.Text,
                productOrderType.Text,

                productID2.Text,
                productCompany2.Text,
                productTickerSymbol2.Text,
                productMarketPrice2.Text,
                productShares2.Text,
                productOrderType2.Text

            };
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);

            listPanel[0].BringToFront();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();

        }

        private void btnModifySale_Click(object sender, EventArgs e)
        {
            listPanel[2].BringToFront();
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            listPanel[3].BringToFront();
        }

        private void btnMainMenuAdd_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();
        }

        private void btnMainMenuModify_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();
        }

        private void btnMainMenuReporting_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            //when user click ok to save file
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid Goetz File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                        goetzWriter = new StreamWriter(output);

                        btnSave.Enabled = false;
                        
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file! Did you call Dr. Goetz?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

           

        }
        private void btnBack_Click(object sender, EventArgs e)
        {

            try
            {
                var goetzRecord = goetzReader.ReadLine();

                if (goetzRecord != null)
                {
                    string[] goetzFields = goetzRecord.Split(',');

                    OpenTextBoxValues(goetzFields);
                }
                else
                {
                    goetzReader.Close();

                    
                    ClearTextBoxes();
                    
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error Reading the File!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                var goetzRecord = goetzReader.ReadLine();

                if (goetzRecord != null)
                {
                    string[] goetzFields = goetzRecord.Split(',');

                    OpenTextBoxValues(goetzFields);
                }
                else
                {
                    goetzReader.Close();
                    
                    
                    ClearTextBoxes();
                    
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error Reading the File!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
