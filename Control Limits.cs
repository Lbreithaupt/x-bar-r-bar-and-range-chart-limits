using System;

namespace SCM_Functions
{
    class Program
    {
        static void Main(string[] args)
        {


            string sigma;
            sigma = "\u03C3";
            Console.WriteLine("Upper Control Limit for x bar charts");
            Console.WriteLine("UCL is defined with the equation:");
            Console.WriteLine("UCL=(x double bar)+(z)*({0})", sigma);
            Console.WriteLine("");
            Console.WriteLine("LCL is defined with the equations:");
            Console.WriteLine("LCL=(x double bar)-(z)*({0})",sigma);
            Console.WriteLine("");
            Console.WriteLine("Which control limits to calculate? enter (1) for x-bar chart or (2) for r-chart control limit or (3) for r chart range limits");
            int program;
            program = Convert.ToInt32(Console.ReadLine());
            if (program == 1)
            {
                Console.WriteLine("Beginning x bar Control Limits");

                try
                {
                    Console.WriteLine("Please input parameters to calculate Control Limits");
                    double xDoubleBar;
                    double z;
                    double sigmaUCL;
                    Console.WriteLine("Please enter x double bar");
                    xDoubleBar = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("please enter z {the number of normal standard devations, 2 for 95.45% confidence, 3 for 99.73% confidence)");
                    z = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter sigma (defined as the population [process] standard deviation) ({0}),", sigma);
                    sigmaUCL = Convert.ToDouble(Console.ReadLine());
                    double n;
                    double oSubXbar;


                    double UCL;
                    Console.WriteLine("Please enter the sample size");
                    n = Convert.ToDouble(Console.ReadLine());
                    oSubXbar = sigmaUCL / (Math.Sqrt(n));



                    UCL = (xDoubleBar) + ((z) * (oSubXbar));

                    Console.WriteLine("The UCL of the inputted parameters is {0}", UCL);
                    double LCL;
                    LCL = (xDoubleBar) - ((z) * (oSubXbar));
                    Console.WriteLine("The LCL is {0}", LCL);
                }
                catch
                {
                    Console.WriteLine("One or more variables was in an incorrect format");
                }
            }
            if (program == 2)
            {
                Console.WriteLine("Beginning R Chart Control limits");
                Console.WriteLine("NOTE:this program references values for 3 sigma");
                int n = 0;
                double A2 = 0;
                double D4 = 0;
                double D3 = 0;
                double xDoubleBar = 0;
                double avgRange = 0;
                double UCL = 0;
                double LCL = 0;

                Console.WriteLine("Please enter the average Range (R BAR)");
                avgRange = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter x double bar (the mean of the means)");
                xDoubleBar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter n (Sample Size)");
                Console.WriteLine("Enter an integer, 2 through 10, or 12.");
                n = Convert.ToInt32(Console.ReadLine());


                if (n == 2)
                {
                    A2 = 1.880;
                    D4 = 3.268;
                    Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL = (xDoubleBar) + (A2 * avgRange);
                    Console.WriteLine("The UCL for the R chart is {0}", UCL);
                    LCL = (xDoubleBar) - (A2 * avgRange);
                    Console.WriteLine("The LCL for the R chart is {0}", LCL);

                }
                else if (n == 3)
                {
                    A2 = 1.023;
                    D4 = 2.574;
                    Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL = (xDoubleBar) + (A2 * avgRange);
                    Console.WriteLine("The UCL for the R chart is {0}", UCL);
                    LCL = (xDoubleBar) - (A2 * avgRange);
                    Console.WriteLine("The LCL for the R chart is {0}", LCL);
                }
                else if (n == 4)
                {
                    A2 = 0.729;
                    D4 = 2.282;
                    Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL = (xDoubleBar) + (A2 * avgRange);
                    Console.WriteLine("The UCL for the R chart is {0}", UCL);
                    LCL = (xDoubleBar) - (A2 * avgRange);
                    Console.WriteLine("The LCL for the R chart is {0}", LCL);
                }
                else if (n == 5)
                {
                    A2 = 0.577;
                    D4 = 2.115;
                    Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL = (xDoubleBar) + (A2 * avgRange);
                    Console.WriteLine("The UCL for the R chart is {0}", UCL);
                    LCL = (xDoubleBar) - (A2 * avgRange);
                    Console.WriteLine("The LCL for the R chart is {0}", LCL);
                }
                else if (n == 6)
                {
                    A2 = 0.483;
                    D4 = 2.004;
                    Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL = (xDoubleBar) + (A2 * avgRange);
                    Console.WriteLine("The UCL for the R chart is {0}", UCL);
                    LCL = (xDoubleBar) - (A2 * avgRange);
                    Console.WriteLine("The LCL for the R chart is {0}", LCL);
                }
                else if (n == 7)
                {
                    A2 = 0.419;
                    D4 = 1.924;
                    D3 = 0.076;
                    Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL = (xDoubleBar) + (A2 * avgRange);
                    Console.WriteLine("The UCL for the R chart is {0}", UCL);
                    LCL = (xDoubleBar) - (A2 * avgRange);
                    Console.WriteLine("The LCL for the R chart is {0}", LCL);
                }
                else if (n == 8)
                {
                    A2 = 0.373;
                    D4 = 1.864;
                    D3 = 0.136;
                    Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL = (xDoubleBar) + (A2 * avgRange);
                    Console.WriteLine("The UCL for the R chart is {0}", UCL);
                    LCL = (xDoubleBar) - (A2 * avgRange);
                    Console.WriteLine("The LCL for the R chart is {0}", LCL);
                }
                else if (n == 9)
                {
                    A2 = 0.337;
                    D4 = 1.816;
                    D3 = 0.184;
                    Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL = (xDoubleBar) + (A2 * avgRange);
                    Console.WriteLine("The UCL for the R chart is {0}", UCL);
                    LCL = (xDoubleBar) - (A2 * avgRange);
                    Console.WriteLine("The LCL for the R chart is {0}", LCL);
                }
                else if (n == 10)
                {
                    A2 = 0.308;
                    D4 = 1.777;
                    D3 = 0.223;
                    Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL = (xDoubleBar) + (A2 * avgRange);
                    Console.WriteLine("The UCL for the R chart is {0}", UCL);
                    LCL = (xDoubleBar) - (A2 * avgRange);
                    Console.WriteLine("The LCL for the R chart is {0}", LCL);
                }
                else if (n == 12)
                {
                    A2 = 0.266;
                    D4 = 1.716;
                    D3 = 0.284;
                    Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL = (xDoubleBar) + (A2 * avgRange);
                    Console.WriteLine("The UCL for the R chart is {0}", UCL);
                    LCL = (xDoubleBar) - (A2 * avgRange);
                    Console.WriteLine("The LCL for the R chart is {0}", LCL);
                }
            }
                if (program == 3)

                {
                    Console.WriteLine("Beginning R Chart RANGE limits");
                    Console.WriteLine("NOTE:this program references values for 3 sigma");
                    int n = 0;
                    double A2 = 0;
                    double D4 = 0;
                    double D3 = 0;
                   
                    double avgRange = 0;
                    double UCL_R = 0;
                    double LCL_R = 0;

                    Console.WriteLine("Please enter the average Range (R BAR)");
                    avgRange = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter n (Sample Size)");
                    Console.WriteLine("Enter an integer, 2 through 10, or 12.");
                    n = Convert.ToInt32(Console.ReadLine());


                    if (n == 2)
                    {
                        A2 = 1.880;
                        D4 = 3.268;
                        Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL_R = D4 * avgRange;
                        Console.WriteLine("The UCL for the R chart is {0}", UCL_R);
                    LCL_R = D3 * avgRange;
                        Console.WriteLine("The LCL for the R chart is {0}", LCL_R);

                    }
                    else if (n == 3)
                    {
                        A2 = 1.023;
                        D4 = 2.574;
                        Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL_R = D4 * avgRange;
                    Console.WriteLine("The UCL for the R chart is {0}", UCL_R);
                    LCL_R = D3 * avgRange;
                    Console.WriteLine("The LCL for the R chart is {0}", LCL_R);
                }
                    else if (n == 4)
                    {
                        A2 = 0.729;
                        D4 = 2.282;
                        Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL_R = D4 * avgRange;
                    Console.WriteLine("The UCL for the R chart is {0}", UCL_R);
                    LCL_R = D3 * avgRange;
                    Console.WriteLine("The LCL for the R chart is {0}", LCL_R);
                }
                    else if (n == 5)
                    {
                        A2 = 0.577;
                        D4 = 2.115;
                        Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL_R = D4 * avgRange;
                    Console.WriteLine("The UCL for the R chart is {0}", UCL_R);
                    LCL_R = D3 * avgRange;
                    Console.WriteLine("The LCL for the R chart is {0}", LCL_R);
                }
                    else if (n == 6)
                    {
                        A2 = 0.483;
                        D4 = 2.004;
                        Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL_R = D4 * avgRange;
                    Console.WriteLine("The UCL for the R chart is {0}", UCL_R);
                    LCL_R = D3 * avgRange;
                    Console.WriteLine("The LCL for the R chart is {0}", LCL_R);
                }
                    else if (n == 7)
                    {
                        A2 = 0.419;
                        D4 = 1.924;
                        D3 = 0.076;
                        Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL_R = D4 * avgRange;
                    Console.WriteLine("The UCL for the R chart is {0}", UCL_R);
                    LCL_R = D3 * avgRange;
                    Console.WriteLine("The LCL for the R chart is {0}", LCL_R);
                }
                    else if (n == 8)
                    {
                        A2 = 0.373;
                        D4 = 1.864;
                        D3 = 0.136;
                        Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL_R = D4 * avgRange;
                    Console.WriteLine("The UCL for the R chart is {0}", UCL_R);
                    LCL_R = D3 * avgRange;
                    Console.WriteLine("The LCL for the R chart is {0}", LCL_R);
                }
                    else if (n == 9)
                    {
                        A2 = 0.337;
                        D4 = 1.816;
                        D3 = 0.184;
                        Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL_R = D4 * avgRange;
                    Console.WriteLine("The UCL for the R chart is {0}", UCL_R);
                    LCL_R = D3 * avgRange;
                    Console.WriteLine("The LCL for the R chart is {0}", LCL_R);
                }
                    else if (n == 10)
                    {
                        A2 = 0.308;
                        D4 = 1.777;
                        D3 = 0.223;
                        Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL_R = D4 * avgRange;
                    Console.WriteLine("The UCL for the R chart is {0}", UCL_R);
                    LCL_R = D3 * avgRange;
                    Console.WriteLine("The LCL for the R chart is {0}", LCL_R);
                }
                    else if (n == 12)
                    {
                        A2 = 0.266;
                        D4 = 1.716;
                        D3 = 0.284;
                        Console.WriteLine("A2={0},D4={1},D3={2}", A2, D4, D3);
                    UCL_R = D4 * avgRange;
                    Console.WriteLine("The UCL for the R chart is {0}", UCL_R);
                    LCL_R = D3 * avgRange;
                    Console.WriteLine("The LCL for the R chart is {0}", LCL_R);
                }
                












                }

                
           

        
            Console.WriteLine("Press enter to exit");
            Console.Read();
        }

    }
}
