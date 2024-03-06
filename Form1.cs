namespace TemperatureConversionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Fahrenheit_Click(object sender, EventArgs e)
        {
            float f = 0;

            try
            {
                f = float.Parse(txt_Fahrenheit.Text);
            }
            catch 
            {
                MessageBox.Show("Use only numbers");
            }

            float c = 5f / 9f * (f - 32);
            float k = c - 273;


            txt_Celsius.Text = c.ToString();
            txt_Kelvin.Text = k.ToString();
        }

        private void btn_Celsius_Click(object sender, EventArgs e)
        {
            float c = 0;

            try
            {
                c = float.Parse(txt_Celsius.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }
           

            float f = (9f / 5f) * c + 32;
            float k = c + 273.15f;

            txt_Fahrenheit.Text = f.ToString();
            txt_Kelvin.Text = k.ToString();
        }

        private void btn_Kelvin_Click(object sender, EventArgs e)
        {
            float k = 0;

            try
            {
                k = float.Parse(txt_Kelvin.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers.");
            }
            

            float f = (k - 273.15f) * 9 / 5 + 32;
            float c = k - 273.15f;

            txt_Fahrenheit.Text = f.ToString();
            txt_Celsius.Text= c.ToString();
        }
    }
}
