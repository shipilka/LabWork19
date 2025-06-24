using Task3;

Circle circle = new Circle();
RedShapeDecorator redCircle = new(new Circle());
RedShapeDecorator redRectangle = new(new Rectangle());
BlueShapeDecorator blueCircle = new(new Circle());
BlueShapeDecorator blueRectangle = new(new Rectangle());

Console.WriteLine("Circle with normal border");
circle.Draw();

Console.WriteLine("Circle of red border");
redCircle.Draw();

Console.WriteLine("Rectangle of red border");
redRectangle.Draw();

Console.WriteLine("Circle of blue border");
blueCircle.Draw();

Console.WriteLine();
Console.WriteLine("Rectangle of blue border");
blueRectangle.Draw();


Subject subject = new();

new HexaObserver(subject);
new OctalObserver(subject);
new BinaryObserver(subject);
new DemicalObserver(subject);

Console.WriteLine("First state change: 15");
subject.SetState(15);
Console.WriteLine();
Console.WriteLine("Second state change: 10");
subject.SetState(10);