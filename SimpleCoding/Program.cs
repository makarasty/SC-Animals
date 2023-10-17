namespace SimpleCoding;

/*
Створити клас Тварина, вспадкувати від нього класи: Риби, Птиці, Савці та Земноводні.
Класс тварина буде мати Name, MovingTypes<spaceType, int>, AddMovingType(), Mode(),
Кожна тваринка буде мати Position и CurrentActyvity

Створити клас Простір, вспадкувати від нього класи: Вода, Земля і Повітря, (в воді можна плавати на землі ходити, а в повітрі літати).
У простору є характеристика тривалість

Створити декілька дочірніх класів риб, наприклад тунець, лосось, риба летяга яка вміє літати
Створити декілька дочірніх класів ссавців що вміють бігати та/або плавати й/або літати (качка). І так далі для кожного класу тварин.

У кожної тварини мусить бути своя швидкість пересування на певному етапі
Наприклад бджола, вона може літати на етапі повітря, ходити на етапі землі, і стояти на етапі води, тому що вона не вміє плавати.
Кожна тварина повинна мати свою швидкість відповідно до того які особливості вона має, наприклад Риба плаває швидше вовка і так далі...

Створити клас Траса, що буде складатись з різних перешкод (вода, земля, повітря)
Траса має в собі декілька наших етапів, кожен з етапів має свою тривалість.
Траса має свою довжину.
На трасу можна ставити тваринок для перегонів, і вони будуть по черзі пробувати пройти даний етап за відповідний час, після чого етап буде змінюватись
На кожному етапі тварини будуть рухатись в перед, або стояти на місті якщо вони не вміють плавати як бджола
Результат проходження етапів потрібно виводити в консоль в вигляді таблиці...
Траса має мати Distance, Steps, Animals, Start(), AddActivityStep(), AddAnimal(), UpdateAnimal()

У кожної тварини є свій особливий вигук, коли тварина завершує перешкоду першою вона вигукує свій клич.
*/

class Program
{
	static void Main(string[] args)
	{
		Console.OutputEncoding = System.Text.Encoding.Unicode;
		Console.CursorVisible = false;

		var track = new Track(100);

		Animal golderFish = new GolderFish();
		Animal salmon = new Salmon();
		Animal tuna = new Tuna();

		Animal flyingFish = new FlyingFish();

		Animal duck = new Duck();

		Animal crow = new Crow();
		Animal parrot = new Parrot();

		Animal hepard = new Hepard();
		Animal horse = new Horse();
		Animal wolf = new Wolf();

		track.AddAnimal(golderFish);
		track.AddAnimal(salmon);
		track.AddAnimal(tuna);

		track.AddAnimal(flyingFish);

		track.AddAnimal(duck);

		track.AddAnimal(crow);
		track.AddAnimal(parrot);

		track.AddAnimal(hepard);
		track.AddAnimal(horse);
		track.AddAnimal(wolf);

		track.AddSpace("water", 6, ConsoleColor.DarkBlue);
		track.AddSpace("land", 4, ConsoleColor.DarkYellow);
		track.AddSpace("air", 5, ConsoleColor.Gray);

		track.Start();

		Console.ReadKey(); // Пауза
		/**/
	}
}
