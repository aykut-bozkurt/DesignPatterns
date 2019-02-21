using Patterns.BehavioralPatterns;
using Patterns.BehavioralPatterns.ObserverDispatcherPattern;
using Patterns.BehavioralPatterns.StatePattern;
using Patterns.BuilderPattern;
using Patterns.CreationalPatterns.PrototypePattern;
using Patterns.CriteriaPattern;
using Patterns.FactoryPattern;
using Patterns.SingletonPattern;
using Patterns.StructuralPatterns.AdapterPattern;
using Patterns.StructuralPatterns.BridgePattern;
using Patterns.StructuralPatterns.DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using Shape = Patterns.StructuralPatterns.DecoratorPattern.Shape;

public class Program
{
	public static void Main()
	{
		#region Creational Patterns)
		//FactoryPatternDemo();

		//SingletonPatternDemo();

		//BuilderPatternDemo();

		//PrototypePatternDemo();

		#endregion

		#region  Structural Patterns
		//AdapterPatternDemo();

		//BridgePatternDemo();

		//DecoratorPatternDemo();

		//CriteriaPatternDemo();

		#endregion

		#region Behavioral Patterns

		//ChainOfResponsibilityDemo();

		//StatePatternDemo();

		//ObserverDispatcherPatternDemo();
			
		#endregion
		Console.ReadKey();
	}

	public static void CriteriaPatternDemo() {
		Person p1 = new Person("Aykut", 24, Gender.MALE);
		Person p2 = new Person("Yilmaz", 55, Gender.MALE);
		Person p3 = new Person("Esra", 50, Gender.FEMALE);
		Person p4 = new Person("Zeynep", 12, Gender.FEMALE);

		List<Person> family = new List<Person>() { p1, p2, p3, p4 };

		ICriteria<Person> maleCriteria = new MaleCriteria();
		ICriteria<Person> femaleCriteria = new FemaleCriteria();
		ICriteria<Person> teenCriteria = new TeenCriteria();

		var males = maleCriteria.Filter(family).ToList();
		var females = femaleCriteria.Filter(family).ToList();
		var teens = teenCriteria.Filter(family).ToList();

		ICriteria<Person> maleAndTeenCriteria = new AndCriteria(maleCriteria, teenCriteria);
		var teenMales = maleAndTeenCriteria.Filter(family);

		ICriteria<Person> femaleAndTeenCriteria = new AndCriteria(femaleCriteria, teenCriteria);
		var teenFemales = femaleAndTeenCriteria.Filter(family);

		ICriteria<Person> maleOrTeenCriteria = new OrCriteria(maleCriteria, teenCriteria);
		var malesOrTeens = maleOrTeenCriteria.Filter(family);
	}

	public static void FactoryPatternDemo() {
		CarFactory carFactory = new CarFactory();

		Car redBugatti = carFactory.GetCar("Bugatti", Color.RED);
		Car pinkPorche = carFactory.GetCar("Porche", Color.PINK);
	}

	public static void SingletonPatternDemo()
	{
		DeviceManager manager1 = DeviceManager.GetInstance();
		DeviceManager manager2 = DeviceManager.GetInstance();
		Console.WriteLine(manager1.GetHashCode());
		Console.WriteLine(manager2.GetHashCode());
	}

	public static void BuilderPatternDemo() {
		HttpRequest.HttpRequestBuilder httpRequestBuilder = new HttpRequest.HttpRequestBuilder("https://www.google.com");

		HttpRequest httpRequest = httpRequestBuilder.SetFilter("q=stuff")
			.SetOrdering("datetime desc")
			.SetSkip(25)
			.SetTop(25)
			.Build();
	}

	public static void PrototypePatternDemo()
	{
		ICache<Customer> customerCache = new CustomerCache();

		Customer c1 = customerCache.GetFromCache(1);
		Customer c2 = customerCache.GetFromCache(1);
	}

	public static void AdapterPatternDemo() {
		MediaAdapter mediAdapter = new MediaAdapter();
		mediAdapter.play("VLC","song1.vlc");
		mediAdapter.play("MP3", "song2.mp3");
		mediAdapter.play("MP4", "song3.mp4");

	}

	public static void BridgePatternDemo() {
		// complex drawing responsibility is left to DrawAPI
		DrawAPI drawAPI = new DrawAPI();

		Patterns.StructuralPatterns.BridgePattern.Shape shape1 = new Patterns.StructuralPatterns.BridgePattern.Circle(drawAPI);
		shape1.drawCircle();

		Patterns.StructuralPatterns.BridgePattern.Shape shape2 = new Patterns.StructuralPatterns.BridgePattern.Rectangle(drawAPI);
		shape2.drawRectangle();
	}

	public static void DecoratorPatternDemo() {
		// when we want to decorate some class, we donot make any changes on the class, instead we use decorator interface to decorate the class
		Patterns.StructuralPatterns.DecoratorPattern.Shape circle = new Patterns.StructuralPatterns.DecoratorPattern.Circle();

		Patterns.StructuralPatterns.DecoratorPattern.ShapeDecorator shapeDecorator = new RedShapeDecorator(circle);
		shapeDecorator.Draw();
	}

	public static void ChainOfResponsibilityPatternDemo() {
		Func<AbstractLogger> getLoggerChain = () =>
		{
			AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
			AbstractLogger debugLogger = new DebugLogger(AbstractLogger.DEBUG);
			AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

			errorLogger.NextLogger = debugLogger;
			debugLogger.NextLogger = consoleLogger;

			return errorLogger;
		};

		getLoggerChain().LogMessage(AbstractLogger.DEBUG, "Hello World!");
	}

	public static void StatePatternDemo() {
		// we can think of it as finite state machine
		State startState = new StartState();
		State stopState = new StopState();

		Context context = new Context();

		startState.DoAction(context);

		stopState.DoAction(context);
	}

	public static void ObserverDispatcherPatternDemo() {
		AbstractDispatcher sumDispatcher = new SumDispatcher();

		sumDispatcher.Dispatch(new SumEvent(20.3,12.4)); // no observer attached to dispatcher

		IObserver intSumObserver = new IntSumObserver();
		sumDispatcher.Attach(intSumObserver);

		sumDispatcher.Dispatch(new SumEvent(11.3, 11.2)); // one observer attached to dispatcher

		IObserver doubleSumObserver = new DoubleSumObserver();
		sumDispatcher.Attach(doubleSumObserver);

		sumDispatcher.Dispatch(new SumEvent(-20.3, 9.8)); // two observers attached to dispatcher
	}
}

