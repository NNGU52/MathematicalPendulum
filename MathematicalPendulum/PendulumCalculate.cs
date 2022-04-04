using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalPendulum
{
    struct PointD
    {
        public double angle;
        public double speed;
        public double time;

        public PointD(double angle_, double speed_, double time_)
        {
            this.angle = angle_;
            this.speed = speed_;
            this.time = time_;
        }
    }

    struct RKresult
    {
	    public double t;
        public double x;
        public double Vx;
        public double xOld;

	    public RKresult(double t_, double x_ , double Vx_)
	    {
		    this.t = t_;
            this.x = x_;
            this.Vx = Vx_;

            this.xOld = x_;
	    }
    }

    class PendulumCalculate
    {
        private const double g = 9.8067;                // Ускорение свободного падения (м/с^2)

        private double Length;                          // Длина маятника
        private double Weight;                          // Вес маятника

        private double dt;                              // Шаг по времени
        public double time;                             // начальное время

        private double ViscousFrictionCoefficient;      // Коэффициент вязкого трения
        private double DryFrictionCoefficient;          // Коэффициент сухого трения

        public double CurrentAngle;                     // Текущий угол отклонения от вертикали математического маятника
        public double CurrentAngleSpeed;                // Текущая скорость маятника

        public double ViscousFrictionForce;             // Сила вязкого трения
        public double DryFrictionForce;                 // Сила сухого трения
        public double MyForce;                          // Сила (задать ее значение самостоятельно)

        public double StartAngle;                       // минимальный угол при котором начинает действовать сила
        public double EndAngle;                         // максимальный угол при котором начинает действовать сила

        private int BWidth, BHeight;                    // Размер области рисования

        public int Number;                              // Количество фазовых траекторий

        public List<PointD> data = new List<PointD>();

        // конструктор
        public PendulumCalculate(double PendulumLength, double PendulumAngle, double PendulumWeight, int BitmatWidth, int BitmatHeight, double PendulumViscousFrictionCoefficient, double PendulumDryFrictionCoefficient, double PendulumStartAngleSpeed, double PendulumMyForce, double PendulumStartAngle, double PendulumEndAngle, int PhaseNumber, double PendulumDt)
        {
            Length = PendulumLength;
            CurrentAngle = Conversion(PendulumAngle);
            Weight = PendulumWeight;
            CurrentAngleSpeed = PendulumStartAngleSpeed;
            dt = PendulumDt;

            BWidth = BitmatWidth;
            BHeight = BitmatHeight;

            ViscousFrictionCoefficient = PendulumViscousFrictionCoefficient;
            DryFrictionCoefficient = PendulumDryFrictionCoefficient;

            MyForce = PendulumMyForce;
            StartAngle = Conversion(PendulumStartAngle);
            EndAngle = Conversion(PendulumEndAngle);

            Number = PhaseNumber;
        }

        double Conversion(double angle)
        {
            double rad = angle * (Math.PI / 180);
            return rad;
        }

        // заполнение листа
        public void FillList()
        {
            double CurAng, CurAngSpeed, time_;
            CurAng = CurrentAngle;
            CurAngSpeed = CurrentAngleSpeed;
            time_  = time;

            for (int i = 0; i < Number; i++)
            {
                data.Add(new PointD(CurAng, CurAngSpeed, time_));
                CurAng -= 0.2;
                CurAngSpeed -= 0.2;
            }
        }

        // для расчета фазовых траекторий
        public double[] PhaseCalculate(double angle, double speed, double time)
        {
            double[] mas = new double[3];
            RKresult Koor = RKMethod(time, angle, speed);
            angle = Koor.x;
            speed = Koor.Vx;
            time = Koor.t;

            mas[0] = angle;
            mas[1] = speed;
            mas[2] = time;
            return mas;
        }

        // Рассчёт силы вязкого трения
        private double CalculateViscousFrictionForce(double V)
        {
            ViscousFrictionForce = -ViscousFrictionCoefficient * V;
            return ViscousFrictionForce;
        }

        // Рассчёт силы сухого трения
        private double CalculateDryFrictionForce(double V)
        {
            if (V > 0)
            {
                DryFrictionForce = -DryFrictionCoefficient * Weight * g;
            }
            else if (V < 0)
            {
                DryFrictionForce = DryFrictionCoefficient * Weight * g;
            }
            return DryFrictionForce;
        }

        // Рассчёт следующего местоположения маятника
        public int[] CalculateFollowingProvision()
        {
            RKresult Koor = RKMethod(time, CurrentAngle, CurrentAngleSpeed);

            CurrentAngle = Koor.x;
            CurrentAngleSpeed = Koor.Vx;
            time = Koor.t;

            int anchorX = (BWidth / 2) - 12,
                anchorY = BHeight / 18,
                ballX = anchorX + (int)(Math.Sin(CurrentAngle) * 200),
                ballY = anchorY + (int)(Math.Cos(CurrentAngle) * 200);

            int[] ResultPoints = {anchorX, anchorY, ballX, ballY};
            return ResultPoints;
        }

        private double formulaAngle(double V)
        {
            return V;
        }

        private double formulaSpeed(double a, double V)
        {
            if (EndAngle <= a && a <= StartAngle)
            {
                return -(g / Length) * a + CalculateViscousFrictionForce(V) + CalculateDryFrictionForce(V) + (MyForce * Length * Math.Sin(a));
            }
            else
            {
                return -(g / Length) * a + CalculateViscousFrictionForce(V) + CalculateDryFrictionForce(V);
            }
            
        }

        private RKresult RKMethod(double t, double a, double v)
        {
	        double k1a, k1v, k2a, k2v, k3a, k3v, k4a, k4v;

            k1v = formulaSpeed(a, v) * dt;
            k1a = formulaAngle(v) * dt;
            k2v = formulaSpeed(a + k1a / 2, v + k1v / 2) * dt;
            k2a = formulaAngle(v + k1v / 2) * dt;
            k3v = formulaSpeed(a + k2a / 2, v + k2v / 2) * dt;
            k3a = formulaAngle(v + k2v / 2) * dt;
            k4v = formulaSpeed(a + k3a, v + k3v) * dt;
            k4a = (v + k3v) * dt;



	        double tNew = t + dt;
	        double aNew = a + (k1a + 2 * k2a + 2 * k3a + k4a) / 6;
	        double vNew = v + (k1v + 2 * k2v + 2 * k3v + k4v) / 6;
            

	        RKresult koor4 = new RKresult(tNew, aNew, vNew);
	        return koor4;
        }
    }
}
