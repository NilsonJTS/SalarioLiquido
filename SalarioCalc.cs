using System.Reflection.Metadata;

namespace Ex_C__Natal_04_09_24;

public class SalarioCalc
{
    public double salario =0;
    public double ir=0;
    public double inss=0;


    public SalarioCalc()
    {
    }

    public void LerDados(){
        Console.WriteLine("Digite seu salário bruto: ");
        this.salario=Convert.ToDouble(Console.ReadLine());
        this.calcular();
    }

    public double calcular(){
        double resultado=0;
        ir = this.salario*0.10;
        inss = this.salario*0.05;
        resultado=this.salario-this.inss-this.ir;
        Console.WriteLine("Valor de INSS: "+this.inss);
        Console.WriteLine("Valor de IR: "+this.ir);
        Console.WriteLine("Salário líquido: "+resultado);
        return resultado;
    }

}
