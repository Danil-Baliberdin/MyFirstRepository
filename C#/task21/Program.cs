/*Задача 21 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int inputNum(string text){
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int xA = inputNum("Введите коордитнаты x для точки A");
int xB = inputNum("Введите коордитнаты x для точки B");
int yA = inputNum("Введите коордитнаты y для точки A");
int yB = inputNum("Введите коордитнаты y для точки B");
int zA = inputNum("Введите коордитнаты z для точки A");
int zB = inputNum("Введите коордитнаты z для точки B");

int x = xA-xB;
int y = yA-yB;
int z = zA-zB;


double distanse = Math.Sqrt(x*x+ y*y + z*z);


Console.WriteLine($"Distanse is - {distanse}"); 