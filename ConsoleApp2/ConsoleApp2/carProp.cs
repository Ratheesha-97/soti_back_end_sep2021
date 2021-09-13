using System;
public class Car
{
	public string manufacturer = string.Empty;
	public string color = "black";
	public string Model = string.Empty;
	public string name = string.Empty;
	public string dateManf = string.Empty;
	private int rate;
	private int model_num;
	private int number;
	private int pdtNo;
	private int no { get; set; }

	public Car() { }
	public int Model_No
	{
		get { return model_num; }
		set { model_num = value; }
	}
	public int Number
	{
		get { return number; }
		set { number = value; }
	}
	public int PdtNo
	{
		get { return pdtNo; }
		set { pdtNo = value; }
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	public string Manufacturer
	{
		get { return manufacturer; }
		set { manufacturer = value; }
	}
	public string Color
	{
		get { return color; }
		set { color = value; }
	}
	public string model
	{
		get { return Model; }
		set { Model = value; }
	}
	public string date
	{
		get { return dateManf; }
		set { dateManf = value; }
	}
	public static void Main(string[] args)
	{
		Car c1 = new Car();
		c1.Model_No = 7657;

		Console.WriteLine(c1.model_num);
		Console.WriteLine(c1.number + " " + c1.no + " " + c1.Color + " " + c1.model);
		c1.color = "blue";
		Console.WriteLine(c1.color);
		c1.no = 9;
		Console.WriteLine(c1.no + " " + c1.pdtNo);
	}
}