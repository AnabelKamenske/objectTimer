using system;
using System.Windows.Form;
using BuisnessLayer;

namespace TimerApp {
    public partial class Form1 : Form {
        private Timer timer;

        public Form1() {
            InitializeComponent();
            timer = new Timer();
        }

        private void btnStart_Click{
            try{
                timer.StartClock();
            }
            catch(StartException ex){
                lblStatus.text = (ex.message);
            }
        }

        private void btnStop_Click{
            try{
                timer.StopClock();
                txtElapsedTime.Text = timer.ElapsedTime;
            }
            catch(StopException ex){
                lblStatus.text = (ex.message);
            }
        }

        private void timer_Tick{
            if(timer != null){
                lblElapsedTime.Text = timer.ElapsedTime
            }
        }

    }
}