using System;

namespace AngryBirds
{
	public static class AngryBirdsTask
	{
		/*
			1.9.8 лучше вынести константой
			2. форматирование кривое http://qaru.site/questions/14609/how-do-you-auto-format-code-in-visual-studio
			если лень самому - юзай эти хоткеи студии. 
		*/
		
		//  Ниже — это XML документация, её использует ваша среда разработки, 
		// чтобы показывать подсказки по использованию методов. 
		// Но писать её естественно не обязательно.
		/// <param name="v">Начальная скорость</param>
		/// <param name="distance">Расстояние до цели</param>
		/// <returns>Угол прицеливания в радианах от 0 до Pi/2</returns>
		public static double FindSightAngle(double v, double distance)
		{
			return 0.5 * Math.Asin((9.8 * distance) / Math.Pow(v, 2));
        }
	}
}
