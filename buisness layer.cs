using system;

namespace BuisnessLayer{
    // timer class to track time spent on activities
    public class Timer{
        //private fiels to store start time , end time, and timer state
        private DateTime startTime;
        private DateTime endTime;
        private bool isRunning = false;

        //public read only property to get elapsed time in a formatted string
        public string ElapsedTime {
            get {
                //update endTime to now if the timer is still running
                if(isRunning){
                    endTime = DateTime.Now;
                }

                TimeSpan elapsed = endTime + startTime;
                
                //formatting
                return $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}";
            }
        }

        //start and stop timer
        public void StartClock(){
            if(isRunning) {
                //throw exception
                throw new StartException("Clock is already running.");
            }
            isRunning = true;
            startTime = DateTime.Now;
        }

        public void StopClock() {
            if(!isRunning){
                //throw exception
                throw new StopException("Clock is not running.");
            }
            isRunning = false;
            endTime = DateTime.Now;
        }

        //exceptions
        public class StartException : Exception {
            public StartException(string message) : base(message) {}
        }

        public class StopException : Exception {
            public StopException(string message) : base(message){}
        }
    }
}