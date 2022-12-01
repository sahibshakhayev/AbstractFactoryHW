using AbstractFactory.Abstract;
using AbstractFactory.Concret;

IJuiceFactory factory = new RegularFactory();
ICola cola = factory.CreateCola();
IPepsi pepsi = factory.CreatePepsi();
