using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace JsonAutoResumé
{
    public partial class Form1 : Form
    {
        string resumeData = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerateJSON_Click(object sender, EventArgs e)
        {
            ResumeFile resume = new ResumeFile()
            {
                FirstName = "\n"+"JOHN LAWRENCE",
                MiddleName = "\n" + "EVANGELISTA",
                LastName = "\n" + "TRINIDAD",
                Birthdate = "\n" + "April 2002",
                Address = "\n" + "My Address, Philippines",
                Email = "\n" + "MyEmail@email.com",
                PhoneNumber = "\n" + "09MyNumber",
                Education = new List<string>
                {
                    "\n\t" + "JHS:$#JHS National HS$#",
                    "SHS:$#SHS National HS$#",
                    "College:$#College University$#"
                },
                Description = "\n" + "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum ut orci nec turpis auctor dignissim. Nunc mollis nulla a turpis semper, nec dictum augue auctor. Maecenas sollicitudin at felis id ornare. Aenean interdum ultricies justo, sit amet efficitur sem pellentesque id. Sed id accumsan tortor. Maecenas porttitor lectus vitae hendrerit fringilla. Suspendisse ultrices sapien eget urna molestie bibendum. Nullam nulla sem, fringilla at nulla fermentum, porttitor porttitor velit.",
                Skills = new List<string> 
                { 
                    "\n\t" + "I have a lot of skills$#",
                    "Skill 1$#",
                    "Skill 2"
                }
            };

            string fname = resume.FirstName.Replace("\n", "");
            string lname = resume.LastName.Replace("\n", "");
            string jsonFile = JsonConvert.SerializeObject(resume, Formatting.None);
            File.WriteAllText(@"C:\Users\Public\Documents\AutoResume\" + lname+ "_" +fname + ".json", jsonFile);
            MessageBox.Show("AutoResume JSON file generated.");

            return;
        }

        private void buttonCreatePDF_Click(object sender, EventArgs e)
        {
            var picture = @"C:\Users\Public\Documents\AutoResume\icon612x612.jpg";

            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "json file|*.json", };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                string json = File.ReadAllText(filename);
                string convertedJSON = JsonConvert.DeserializeObject<ResumeFile>(json).ToString();

                string eachData = convertedJSON;
                eachData = eachData.Replace(",", "");
                string[] startNewCell = new string[] {"\n"};
                string[] Data = eachData.Split(startNewCell, StringSplitOptions.TrimEntries);

                PdfPTable table = new PdfPTable(2);

                try
                {
                    int i = 0;
                    foreach (string cell in Data)
                    {
                        Data[i] = cell.Replace("$#", "\n\t");
                        table.AddCell(Data[i]);
                        i++;
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                    return;
                }
                
                SaveFileDialog savePath = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true};
                if (savePath.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document pdf = new iTextSharp.text.Document(PageSize.LETTER);
                    PdfWriter.GetInstance(pdf, new FileStream(savePath.FileName, FileMode.Create));
                    pdf.Open();
                    pdf.Add(new iTextSharp.text.Paragraph(textBox1.Text));
                    iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(picture);
                    jpg.ScaleToFit(204f, 204f);
                    jpg.Alignment = Element.ALIGN_RIGHT;
                    pdf.Add(jpg);
                    table.SpacingBefore = 5f;
                    pdf.Add(table);
                    pdf.Close();
                    MessageBox.Show("AutoResume PDF file created.");
                }
            }
        }
    }
}