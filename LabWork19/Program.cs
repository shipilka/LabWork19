using LabWork19;

Context context = new(new OperationAdd());
Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));

context = new(new OperationSubstract());
Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));

context = new(new OperationMultiply());
Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5));

context = new(new OperationDivided());
Console.WriteLine("10 / 5 = " + context.ExecuteStrategy(10, 5));


ShapeFactory shapeFactory = new();

IShape? shape1 = shapeFactory.PropertyShape("CIRCLE");
shape1?.Draw();

IShape? shape2 = shapeFactory.PropertyShape("RECTANGLE");
shape2?.Draw();

IShape? shape3 = shapeFactory.PropertyShape("SQUARE");
shape3?.Draw();

IShape? shape4 = shapeFactory.PropertyShape("PENTAGON");
shape4?.Draw();
