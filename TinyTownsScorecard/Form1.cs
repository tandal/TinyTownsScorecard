using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyTownsScorecard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addImageBtn_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    finalGameImage.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void calculateTotalBtn_Click(object sender, EventArgs e)
        {
            int warehouse = Convert.ToInt32(warehouseValue.Value);
            int cottage = Convert.ToInt32(cottageValue.Value);
            int chapel = Convert.ToInt32(chapelValue.Value);
            int tavern = Convert.ToInt32(tavernValue.Value);
            int bakery = Convert.ToInt32(bakeryValue.Value);
            int well = Convert.ToInt32(wellValue.Value);
            int monument = Convert.ToInt32(monumentValue.Value);
            int negative = Convert.ToInt32(negativeValue.Value);
            int total = Convert.ToInt32(totalValue.Value);

            totalValue.Value = warehouse + cottage + chapel + tavern + bakery + well + monument + negative;
        }

        private void clearCardBtn_Click(object sender, EventArgs e)
        {
            builderNameTxt.Clear();
            warehouseValue.Value = 0;
            cottageValue.Value = 0;     
            chapelValue.Value = 0;
            tavernValue.Value = 0;
            bakeryValue.Value = 0;
            wellValue.Value = 0;
            monumentValue.Value = 0;
            negativeValue.Value = 0;
            finalGameImage.Image = null;
            totalValue.Value = 0;
        }
    }
}