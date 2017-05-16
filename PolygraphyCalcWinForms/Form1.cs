using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookProduction;
using BookProduction.TypographyManagement;
using BookProduction.BookComponents;
using BookProduction.Assembly;
using BookProduction.IssueParams;
using BookProduction.Paper;
using BookProduction.PriceLists;
using BookProduction.PrintingPresses;
using BookProduction.Tasks;
using PolygraphyCalcWinForms.App_Data;


namespace PolygraphyCalcWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Тираж
            txtPrintRun.Text = "1000";

            //Количество страниц
            txtPages.Text = "128";

            //Формат ВБ
            cBox_Format.Items.AddRange(new[] { "60*90/16", "60*90/8", "84*108/16", "84*108/32", "70*100/16" });
            cBox_Format.SelectedIndex = 0;

            //Бумага ВБ
            List<PaperTypes> IB_PaperTypes = new List<PaperTypes>()
            {
                new PaperTypes() {Id = BookProduction.PaperFullType.Newsprint_45, Name="газетка 45 г/м2" },
                new PaperTypes() {Id = BookProduction.PaperFullType.Offset_60, Name="офсет 60 г/м2" },
                new PaperTypes() {Id = BookProduction.PaperFullType.Offset_80, Name="офсет 80 г/м2" }
            };

            cBox_IB_Paper.DataSource = IB_PaperTypes;
            cBox_IB_Paper.DisplayMember = "Name";
            cBox_IB_Paper.ValueMember = "Id";
            cBox_IB_Paper.SelectedIndex = 0;

            //Цветность ВБ
            cBox_IB_Colors.Items.AddRange(new[] { "1+1", "2+2", "4+4" });
            cBox_IB_Colors.SelectedIndex = 0;

            //Бумага Обложки
            List<PaperTypes> CoverPaperTypes = new List<PaperTypes>()
            {
                new PaperTypes() {Id = BookProduction.PaperFullType.FoldingBoxboard_230, Name="хром-эрзац 230 г/м2" },
                new PaperTypes() {Id = BookProduction.PaperFullType.CardboardAliaska_230, Name="картон Аляска 230 г/м2" }
            };

            cBox_Cov_Paper.DataSource = CoverPaperTypes;
            cBox_Cov_Paper.DisplayMember = "Name";
            cBox_Cov_Paper.ValueMember = "Id";
            cBox_Cov_Paper.SelectedIndex = 0;

            //Цветность обложки
            cBox_Cov_Colors.Items.AddRange(new[] { "4+0", "4+1", "4+4" });
            cBox_Cov_Colors.SelectedIndex = 0;

            //Переплет
            rBtn_Saddle.Checked = true;

            //Ламинация
            checkBoxLamination.Checked = false;

            //Упаковка
            checkBoxPackaging.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookModel bookModel = new BookModel();

            int printRun = 0;
            Int32.TryParse(txtPrintRun.Text, out printRun);
            bookModel.PrintRun = printRun;
            if (bookModel.PrintRun == 0)
            {
                lbl_ValidPrintrun.Text = "Введите числовое значение тиража";
                return;
            }

            int pagesNumber;
            Int32.TryParse(txtPages.Text, out pagesNumber);
            bookModel.PagesNumber = pagesNumber;
            if (bookModel.PagesNumber == 0 || bookModel.PagesNumber % 8 != 0)
            {
                 lbl_ValidationPages.Text = "Количество страниц должно быть кратно 8";
                return;
            }

            bookModel.IBFormat = cBox_Format.Text;
            bookModel.IBPaper = (PaperFullType)cBox_IB_Paper.SelectedValue;
            bookModel.IBColors = cBox_IB_Colors.Text;

            bookModel.CoverPaper = (PaperFullType)cBox_Cov_Paper.SelectedValue;
            bookModel.CoverColors = cBox_Cov_Colors.Text;

            if (rBtn_Saddle.Checked == true)
            {
                bookModel.Binding = BindingType.SaddleStitching;
            }
            else if (rBtn_Perfect.Checked == true)
            {
                bookModel.Binding = BindingType.PerfectBinding;
            }
            else bookModel.Binding = BindingType.HardcoverBinding;

            bookModel.Perforation = false;

            if (checkBoxLamination.Checked == true)
            {
                bookModel.Lamination = LaminationType.Glossy;
            }
            else if (checkBoxLamination.Checked == false)
            {
                bookModel.Lamination = LaminationType.withoutLamination;
            }

            bookModel.Id = "noId";
            bookModel.Name = "Unknown";

            try
            {
            //расчет Полиграфических затрат
            Book theBook = new Book(bookModel);

            DirectorOfTypography director = new DirectorOfTypography(theBook);
            BookCostOfPolygraphy report = director.MakeBook();

            lbl_PolygraphyVal.Text = String.Format("{0:#,###.##}", report.CostOfPolygraphy) + " грн / UAH";
            lbl_MaterialsVal.Text = String.Format("{0:#,###.##}", report.CostOfMaterials) + " грн / UAH";
            lbl_AssemblyVal.Text = String.Format("{0:#,###.##}", report.CostOfAssembly) + " грн / UAH";
            lbl_TotalVal.Text = String.Format("{0:#,###.##}", report.CostOfPrintRun) + " грн / UAH";
            lbl_PerItemVal.Text = String.Format("{0:#,###.##}", report.CostOfPolygraphyPerOneItem) + " грн / UAH";
            }
            catch
            {
                lbl_Message.Text = "Что-то пошло не так. Перезапустите приложение";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
