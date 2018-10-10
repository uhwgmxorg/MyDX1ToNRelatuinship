using System;
using System.Windows.Forms;

namespace MyDX1ToNRelatuinship
{
    public partial class FormMain : Form
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            gridView1.CellValueChanged += GridView1_CellValueChanged;
        }

        /******************************/
        /*       Button Events        */
        /******************************/
        #region Button Events

        /// <summary>
        /// buttonReload_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// buttonClose_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            SaveData();
            Close();
        }

        #endregion

        /******************************/
        /*      Menu Events          */
        /******************************/
        #region Menu Events

        #endregion

        /******************************/
        /*      Other Events          */
        /******************************/
        #region Other Events

        /// <summary>
        /// FormMain_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        /// <summary>
        /// GridView1_CellValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            SaveData();
        }

        #endregion

        /******************************/
        /*      Other Functions       */
        /******************************/
        #region Other Functions

        /// <summary>
        /// LoadDate
        /// </summary>
        private void LoadData()
        {
            personTableAdapter1.Fill(testDBDataSet1.Person);
            bookTableAdapter1.Fill(testDBDataSet1.Book);
        }

        /// <summary>
        /// SaveDate
        /// </summary>
        private void SaveData()
        {
            personTableAdapter1.Update(testDBDataSet1.Person);
            bookTableAdapter1.Update(testDBDataSet1.Book);
        }

        #endregion
    }
}
