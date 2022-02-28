Console.WriteLine("desglose de Dinero");
float CAN;
double DOL = 7.72, CAl, CAl1;
int B200, B100, B50, B20, B10, B5, B1;
int M50, M25, M10, M05, M01;
B200 = 0;
B100 = 0;
B50 = 0;
B20 = 0;
B10 = 0;
B5 = 0;
B1 = 0;
M50 = 0;
M25 = 0;
M10 = 0;
M05 = 0;
M01 = 0;
string j;
Console.Write("Indica una cantidad en dolares:");
j = Console.ReadLine();
CAl = Convert.ToDouble(j);
CAl1 = CAl * DOL;
CAN = Convert.ToSingle(CAl1);
Console.WriteLine($"La Cantidad introducida es:{CAN} quetzles");
if ((CAN >= 200))
{
	B200 = ((int)CAN / 200);
	CAN = CAN - (B200 * 200);
}
if ((CAN >= 100))
{
	B100 = ((int)CAN / 100);
	CAN = CAN - (B100 * 100);
}
if ((CAN >= 50))
{
	B50 = ((int)CAN / 50);
	CAN = CAN - (B50 * 50);
}
if ((CAN >= 20))
{
	B20 = ((int)CAN / 20);
	CAN = CAN - (B20 * 20);
}
if ((CAN >= 10))
{
	B10 = ((int)CAN / 10);
	CAN = CAN - (B10 * 10);
}
if ((CAN >= 5))
{
	B5 = ((int)CAN / 5);
	CAN = CAN - (B5 * 5);
}
if ((CAN >= 1))
{
	B1 = ((int)CAN / 1);
	CAN = CAN - (B1 * 1);
}
if ((CAN >= 0.5))
{
	M50 = (int)(CAN / 0.5);
	CAN = CAN - (float)(M50 * 0.5);
}
if ((CAN >= 0.25))
{
	M25 = (int)(CAN / 0.25);
	CAN = CAN - (float)(M25 * 0.25);
}
if ((CAN >= 0.1))
{
	M10 = (int)(CAN / 0.1);
	CAN = CAN - (float)(M10 * 0.1);
}
if ((CAN >= 0.05))
{
	M05 = (int)(CAN / 0.05);
	CAN = CAN - (float)(M05 * 0.05);
}
if ((CAN >= 0.01))
{
	M01 = (int)(CAN / 0.01);
	CAN = CAN - (float)(M01 * 0.01);
}
Console.WriteLine("Billetes de 200: " + B200);
Console.WriteLine("Billetes de 100: " + B100);
Console.WriteLine("Billetes de 50 : " + B50);
Console.WriteLine("Billetes de 20 : " + B20);
Console.WriteLine("Billetes de 10 : " + B10);
Console.WriteLine("Billetes de 5  : " + B5);
Console.WriteLine("Monedas de 1   : " + B1);
Console.WriteLine("Monedas de 0,50: " + M50);
Console.WriteLine("Monedas de 0,25: " + M25);
Console.WriteLine("Monedas de 0,10: " + M10);
Console.WriteLine("Monedas de 0,05: " + M05);
Console.WriteLine("Monedas de 0,01: " + M01);