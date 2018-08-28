using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotiTInClassButtF
{
    public class Machine
    {
        int balance;
        Reel reel1 = new Reel();
        Reel reel2 = new Reel();
        Reel reel3 = new Reel();

        public Machine()
        {
            this.balance = 0;
        }
        public int Balance
        {
            get { return this.balance; }
        }
        public string start()
        {
            int r1, r2, r3;
            this.balance--;
            r1 = this.reel1.spin();
            r2 = this.reel2.spin();
            r3 = this.reel3.spin();
            return r1.ToString() + r2.ToString() + r3.ToString();
        }
        public void moneyin()
        {
            this.balance++;
        }
        public void moneyout()
        {
            this.balance = 0;
        }
    }
    public class Reel
    {
        Random random = new Random();
        int value;

        public Reel()
        {
            value = random.Next(1, 10);

        }
        public int spin()
        {
            value = random.Next(1, 10);
            return value;
        }
    }
}